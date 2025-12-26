using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static tr.Globals;

namespace tr.Forms
{
    public partial class AccountInfoForm : Form
    {
        private int _clientId;

        public AccountInfoForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
            LoadClientData();
        }

        public void RefreshData() 
        {
            LoadClientData();
        }

        private void LoadClientData()
        {
            try
            {
                // загружаем основные данные клиента
                string clientQuery = @"
                    SELECT fio, phone, passport_series, passport_number
                    FROM clients_data
                    WHERE client_id = @client_id;";

                using (var command = new NpgsqlCommand(clientQuery, connection))
                {
                    command.Parameters.AddWithValue("@client_id", _clientId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullName = reader["fio"].ToString();
                            string phone = reader["phone"].ToString();
                            string passportSeries = reader["passport_series"].ToString();
                            string passportNumber = reader["passport_number"].ToString();

                            label_welcome.Text = $"Добро пожаловать, {fullName}!";
                            label_contact.Text = $"Тел: {phone} | Паспорт: {passportSeries} {passportNumber}";
                        }
                        else
                        {
                            MessageBox.Show("Данные клиента не найдены.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            return;
                        }
                    }
                }

                // Вычисляем баланс и задолженность
                ComputeBalanceAndDebt();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных клиента: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ComputeBalanceAndDebt()
        {
            try
            {
                // Запрос для вычисления общей одобренной суммы и общей суммы платежей через функцию
                string query = @"
            WITH contract_totals AS (
                SELECT SUM(approved_amount) AS total_approved
                FROM records r
                JOIN contracts_data c ON r.contract_id = c.contract_id
                WHERE r.client_id = @client_id AND r.status = 'одобрено'
            ),
            payment_totals AS (
                SELECT get_total_payments(@client_id) AS total_payments -- <<< Вызов функции
            )
            SELECT 
                COALESCE(ct.total_approved, 0) AS total_approved,
                COALESCE(pt.total_payments, 0) AS total_payments
            FROM contract_totals ct
            CROSS JOIN payment_totals pt;";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@client_id", _clientId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal totalApproved = reader.GetDecimal("total_approved");
                            decimal totalPayments = reader.GetDecimal("total_payments");
                            decimal currentDebt = totalApproved - totalPayments;

                            // обновляем метки
                            label_balance.Text = $"Баланс: +{totalPayments:N2} руб. (внесено платежей)";
                            label_debt.Text = $"Общая задолженность: {currentDebt:N2} руб. из {totalApproved:N2} руб.";
                        }
                        else
                        {
                            // Если нет одобренных договоров
                            label_balance.Text = "Баланс: 0.00 руб. (внесено платежей)";
                            label_debt.Text = "Общая задолженность: 0.00 руб.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении баланса: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_new_application_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewApplicationForm form = new NewApplicationForm(_clientId);
            form.ReturnToAccountInfo = () => { this.RefreshData(); this.Show(); };
            form.Show();
        }

        private void button_make_payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentForm form = new PaymentForm(_clientId);
            form.ReturnToAccountInfo = () => { this.RefreshData(); this.Show(); };
            form.Show();
        }

        private void button_profile_settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileSettingsForm form = new ProfileSettingsForm(_clientId);
            form.ReturnToAccountInfo = () => { this.RefreshData(); this.Show(); };
            form.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            var authForm = new AuthorizationForm();
            authForm.Show();
        }
    }
}