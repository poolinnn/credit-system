using Npgsql;
using System;
using System.Windows.Forms;
using static tr.Globals;

namespace tr.Forms
{
    public partial class ProfileSettingsForm : Form
    {
        public Action ReturnToAccountInfo;
        private int _clientId;

        public ProfileSettingsForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
            LoadClientData();
        }

        private void LoadClientData()
        {
            try
            {
                // загружаем данные клиента из clients_data
                string query = @"
                    SELECT fio, phone, passport_series, passport_number, login
                    FROM clients_data
                    WHERE client_id = @client_id;";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@client_id", _clientId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox_fio.Text = reader["fio"].ToString();
                            textBox_phone.Text = reader["phone"].ToString();
                            textBox_passport_series.Text = reader["passport_series"].ToString();
                            textBox_passport_number.Text = reader["passport_number"].ToString();
                            textBox_login.Text = reader["login"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Данные клиента не найдены.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных клиента: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string fio = textBox_fio.Text?.Trim();
            string phone = textBox_phone.Text?.Trim();
            string passportSeries = textBox_passport_series.Text?.Trim();
            string passportNumber = textBox_passport_number.Text?.Trim();
            string login = textBox_login.Text?.Trim();
            string password = textBox_password.Text?.Trim();

            if (string.IsNullOrEmpty(fio))
            {
                MessageBox.Show("Пожалуйста, введите ФИО.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Пожалуйста, введите телефон.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(passportSeries) || string.IsNullOrEmpty(passportNumber))
            {
                MessageBox.Show("Пожалуйста, введите серию и номер паспорта.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Пожалуйста, введите логин.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            try
            {
                using (var transaction = connection.BeginTransaction())
                {
                    // Обновляем clients_data
                    string updateClientQuery = @"
                        UPDATE clients_data
                        SET fio = @fio, phone = @phone, passport_series = @passport_series, passport_number = @passport_number, login = @login
                        WHERE client_id = @client_id;";

                    using (var command = new NpgsqlCommand(updateClientQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@fio", fio);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@passport_series", passportSeries);
                        command.Parameters.AddWithValue("@passport_number", passportNumber);
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@client_id", _clientId);

                        command.ExecuteNonQuery();
                    }

                    // если введён пароль, обновляем user_credentials
                    if (!string.IsNullOrEmpty(password))
                    {
                     
                        string storedPassword = password; 

                        string updatePasswordQuery = @"
                            UPDATE user_credentials
                            SET password = @password
                            WHERE login = @login;";

                        using (var command = new NpgsqlCommand(updatePasswordQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@password", storedPassword);
                            command.Parameters.AddWithValue("@login", login);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Логин не найден в таблице учётных данных. Пароль не обновлён.", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }

                    transaction.Commit();

                    MessageBox.Show("Данные успешно сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnToAccountInfo?.Invoke(); 
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReturnToAccountInfo?.Invoke();
            this.Close();
        }
    }
}