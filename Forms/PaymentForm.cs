using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static tr.Globals;

namespace tr.Forms
{
    public partial class PaymentForm : Form
    {
        public Action ReturnToAccountInfo; 
        private int _clientId;

        public PaymentForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
            LoadContracts();
        }

        private void LoadContracts()
        {
            try
            {
                string query = @"
                    SELECT r.contract_id, c.approved_amount, c.approved_term_months, c.contract_sign_date, c.loan_issue_date, c.retention_period_end
                    FROM records r
                    JOIN contracts_data c ON r.contract_id = c.contract_id
                    WHERE r.client_id = @client_id AND r.status = 'одобрено'
                    ORDER BY c.contract_sign_date DESC;";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@client_id", _clientId);
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count > 0)
                        {
                            comboBox_contract.DisplayMember = "contract_id";
                            comboBox_contract.ValueMember = "contract_id";
                            comboBox_contract.DataSource = dt;
                            comboBox_contract.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("У вас нет активных договоров.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button_submit.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке договоров: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void comboBox_contract_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRow = (DataRowView)comboBox_contract.SelectedItem;
            if (selectedRow != null)
            {
                var approvedAmount = selectedRow["approved_amount"] as decimal?;
                var term = selectedRow["approved_term_months"] as int?;
                var signDate = selectedRow["contract_sign_date"] as DateTime?;
                var issueDate = selectedRow["loan_issue_date"] as DateTime?;
                var endDate = selectedRow["retention_period_end"] as DateTime?;

                string info = $"Сумма: {approvedAmount?.ToString("N2") ?? "N/A"} руб. | ";
                info += $"Срок: {term?.ToString() ?? "N/A"} мес. | ";
                info += $"Дата подписания: {signDate?.ToString("dd.MM.yyyy") ?? "N/A"} | ";
                info += $"Дата выдачи: {issueDate?.ToString("dd.MM.yyyy") ?? "N/A"} | ";
                info += $"Окончание: {endDate?.ToString("dd.MM.yyyy") ?? "N/A"}";

                label_contract_info.Text = info;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (comboBox_contract.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите договор.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox_amount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную сумму платежа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime paymentDate = dateTimePicker_date.Value;
            int contractId = Convert.ToInt32(comboBox_contract.SelectedValue);

            try
            {
                using (var transaction = connection.BeginTransaction())
                {
                    string payment_query = @"
                        INSERT INTO payments_data (payment_date, payment_amount, payment_type, contract_id)
                        VALUES (@payment_date, @payment_amount, 'платёж', @contract_id)
                        RETURNING payment_id;";
                    int payment_id;
                    using (var command = new NpgsqlCommand(payment_query, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@payment_date", paymentDate);
                        command.Parameters.AddWithValue("@payment_amount", amount);
                        command.Parameters.AddWithValue("@contract_id", contractId);
                        payment_id = (int)command.ExecuteScalar();
                    }

                    transaction.Commit();

                    MessageBox.Show("Платёж успешно внесён!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnToAccountInfo?.Invoke(); 
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при внесении платежа: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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