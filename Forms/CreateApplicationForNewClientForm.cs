using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static tr.Globals;

namespace tr.Forms
{
    public partial class CreateApplicationForNewClientForm : Form
    {
        public Action ReturnToManageForm; // событие возврата
        private int _managerId;

        public CreateApplicationForNewClientForm(int managerId)
        {
            InitializeComponent();
            _managerId = managerId;
            LoadCreditTypes();
            LoadInspectors();
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

                        comboBox_credit_type.DisplayMember = "name";
                        comboBox_credit_type.ValueMember = "credit_type_id";
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

        private void LoadInspectors()
        {
            try
            {
                string query = "SELECT employee_id, fio FROM employees_data WHERE role = 'inspector' ORDER BY fio;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        comboBox_inspector.DisplayMember = "fio";
                        comboBox_inspector.ValueMember = "employee_id";
                        comboBox_inspector.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке инспекторов: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            // Валидация
            if (string.IsNullOrWhiteSpace(textBox_fio.Text))
            {
                MessageBox.Show("Пожалуйста, введите ФИО.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_phone.Text))
            {
                MessageBox.Show("Пожалуйста, введите телефон.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_passport_series.Text) || string.IsNullOrWhiteSpace(textBox_passport_number.Text))
            {
                MessageBox.Show("Пожалуйста, введите серию и номер паспорта.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_login.Text))
            {
                MessageBox.Show("Пожалуйста, введите логин.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_password.Text))
            {
                MessageBox.Show("Пожалуйста, введите пароль.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            if (comboBox_inspector.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите инспектора.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fio = textBox_fio.Text.Trim();
            string phone = textBox_phone.Text.Trim();
            string passportSeries = textBox_passport_series.Text.Trim();
            string passportNumber = textBox_passport_number.Text.Trim();
            string login = textBox_login.Text.Trim();
            string password = textBox_password.Text.Trim();
            int creditTypeId = Convert.ToInt32(comboBox_credit_type.SelectedValue);
            int term = (int)numericUpDown_term.Value;
            int inspectorId = Convert.ToInt32(comboBox_inspector.SelectedValue);

            try
            {
                using (var transaction = connection.BeginTransaction())
                {
                    // 1. Сначала создаём учётные данные
                    string credentialQuery = @"
                        INSERT INTO user_credentials (login, password)
                        VALUES (@login, @password);";
                    using (var command = new NpgsqlCommand(credentialQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);
                        command.ExecuteNonQuery();
                    }

                    // 2. Теперь вставляем нового клиента — логин уже существует
                    string clientQuery = @"
                        INSERT INTO clients_data (fio, phone, passport_series, passport_number, login)
                        VALUES (@fio, @phone, @passport_series, @passport_number, @login)
                        RETURNING client_id;";
                    int clientId;
                    using (var command = new NpgsqlCommand(clientQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@fio", fio);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@passport_series", passportSeries);
                        command.Parameters.AddWithValue("@passport_number", passportNumber);
                        command.Parameters.AddWithValue("@login", login);
                        clientId = (int)command.ExecuteScalar();
                    }

                    // 3. Создаём пустой контракт
                    string contractQuery = @"
                        INSERT INTO contracts_data (approved_amount, approved_term_months, contract_sign_date, loan_issue_date, retention_period_end)
                        VALUES (NULL, NULL, NULL, NULL, NULL)
                        RETURNING contract_id;";
                    int contractId;
                    using (var command = new NpgsqlCommand(contractQuery, connection, transaction))
                    {
                        contractId = (int)command.ExecuteScalar();
                    }

                    // 4. Вставляем заявку (БЕЗ payment_id!)
                    string recordQuery = @"
                        INSERT INTO records (
                            client_id, contract_id, credit_type_id, application_date, requested_amount, requested_term_months, status, manager_id, inspector_id
                        ) VALUES (
                            @client_id, @contract_id, @credit_type_id, @application_date, @requested_amount, @requested_term_months, @status, @manager_id, @inspector_id
                        );";
                    using (var command = new NpgsqlCommand(recordQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@client_id", clientId);
                        command.Parameters.AddWithValue("@contract_id", contractId);
                        command.Parameters.AddWithValue("@credit_type_id", creditTypeId);
                        command.Parameters.AddWithValue("@application_date", DateTime.Today);
                        command.Parameters.AddWithValue("@requested_amount", amount);
                        command.Parameters.AddWithValue("@requested_term_months", term);
                        command.Parameters.AddWithValue("@status", "на проверке");
                        command.Parameters.AddWithValue("@manager_id", _managerId);
                        command.Parameters.AddWithValue("@inspector_id", inspectorId);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Заявка успешно создана и отправлена инспектору!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnToManageForm?.Invoke();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заявки: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReturnToManageForm?.Invoke();
            this.Close();
        }
    }
}