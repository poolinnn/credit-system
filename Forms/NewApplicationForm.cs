using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static tr.Globals;

namespace tr.Forms
{
    public partial class NewApplicationForm : Form
    {
        public Action ReturnToAccountInfo; // <<< Делегат для возврата
        private int _clientId;

        public NewApplicationForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
            LoadCreditTypes();
        }

        private void LoadCreditTypes()
        {
            try
            {
                string query = "SELECT credit_type_id, name FROM credit_type ORDER BY name;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Привязываем данные к ComboBox
                        comboBox_credit_type.DisplayMember = "name"; // Отображаемое имя
                        comboBox_credit_type.ValueMember = "credit_type_id"; // Значение
                        comboBox_credit_type.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке типов кредита: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            // Валидация
            if (comboBox_credit_type.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите тип кредита.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox_amount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную сумму.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int term = (int)numericUpDown_term.Value;

            try
            {
                using (var transaction = connection.BeginTransaction())
                {
                    // создаем пустой контракт
                    string contract_query = @"
                        INSERT INTO contracts_data (approved_amount, approved_term_months, contract_sign_date, loan_issue_date, retention_period_end)
                        VALUES (NULL, NULL, NULL, NULL, NULL)
                        RETURNING contract_id;";
                    int contract_id;
                    using (var command = new NpgsqlCommand(contract_query, connection, transaction))
                    {
                        contract_id = (int)command.ExecuteScalar();
                    }

                    //создаем пустой платеж
                    string payment_query = @"
                        INSERT INTO payments_data (payment_date, payment_amount, payment_type)
                        VALUES (CURRENT_DATE, 0.00, 'заявка')
                        RETURNING payment_id;";
                    int payment_id;
                    using (var command = new NpgsqlCommand(payment_query, connection, transaction))
                    {
                        payment_id = (int)command.ExecuteScalar();
                    }

                    // вставляем в таблицу records
                    string record_query = @"
                        INSERT INTO records (
                            client_id, contract_id, credit_type_id, application_date, requested_amount, requested_term_months, status
                        ) VALUES (
                            @client_id, @contract_id, @credit_type_id, @application_date, @requested_amount, @requested_term_months, @status
                        );";
                    using (var command = new NpgsqlCommand(record_query, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@client_id", _clientId);
                        command.Parameters.AddWithValue("@contract_id", contract_id);       
                        command.Parameters.AddWithValue("@credit_type_id", Convert.ToInt32(comboBox_credit_type.SelectedValue));
                        command.Parameters.AddWithValue("@application_date", DateTime.Today);
                        command.Parameters.AddWithValue("@requested_amount", amount);
                        command.Parameters.AddWithValue("@requested_term_months", term);
                        command.Parameters.AddWithValue("@status", "на проверке");

                        command.ExecuteNonQuery();
                    }

                    // фиксируем транзакцию
                    transaction.Commit();

                    MessageBox.Show("Заявка успешно отправлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnToAccountInfo?.Invoke(); 
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отправке заявки: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_back_Click(object sender, EventArgs e) 
        {
            ReturnToAccountInfo?.Invoke(); 
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}