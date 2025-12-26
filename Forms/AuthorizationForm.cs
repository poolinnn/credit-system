using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static tr.Globals;

namespace tr.Forms
{
    public partial class AuthorizationForm : Form
    {
        private bool isPasswordVisible = false; // переменная для отслеживания видимости пароля

        public AuthorizationForm()
        {
            InitializeComponent();
        
            textBox_password.UseSystemPasswordChar = true;
            button_showPassword.Text = "*";
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string entered_login = textBox_login.Text?.Trim();
            string entered_password = textBox_password.Text;

            if (string.IsNullOrEmpty(entered_login))
            {
                MessageBox.Show("Пожалуйста, введите логин.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(entered_password))
            {
                MessageBox.Show("Пожалуйста, введите пароль.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string stored_password = null;
            int user_id = -1;
            string user_type = null; // "employee" или "client"
            string employee_role = null; // "manager", "inspector", "other"

            try
            {
                // 1. Проверяем, есть ли логин в user_credentials и получаем пароль
                string query = "SELECT password FROM user_credentials WHERE login = @login;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", entered_login);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        stored_password = result.ToString();
                    }
                }

                if (stored_password == null)
                {
                    MessageBox.Show("Нет пользователя с таким логином!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Сравниваем введенный пароль с паролем из базы данных (БЕЗ ХЭШИРОВАНИЯ)
                if (entered_password != stored_password)
                {
                    MessageBox.Show("Неверный пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Определяем, кто пользователь: сотрудник или клиент
                // Проверяем сначала в employees_data
                query = "SELECT employee_id, role FROM employees_data WHERE login = @login;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", entered_login);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user_id = reader.GetInt32("employee_id");
                            employee_role = reader.GetString("role"); // manager, inspector, other
                            user_type = "employee";
                            
                        }
                       
                    }
                } 

                if (user_type == null)
                {
                    // если не нашли в employees_data, проверяем в clients_data
                    query = "SELECT client_id FROM clients_data WHERE login = @login;";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", entered_login);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            user_id = Convert.ToInt32(result);
                            user_type = "client";
                        }
                    }
                }

                if (user_type == null)
                {
                    // логин есть в user_credentials, но не привязан ни к сотруднику, ни к клиенту
                    MessageBox.Show("Логин найден, но не привязан ни к сотруднику, ни к клиенту.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // открываем соответствующую форму
                Form nextForm = null;
                if (user_type == "client")
                {
                    nextForm = new AccountInfoForm(user_id);
                }
                else if (user_type == "employee")
                {
                    if (employee_role == "manager")
                    {
                      
                        nextForm = new ManageForm(user_id);
                    }
                    else if (employee_role == "inspector")
                    {
                        
                        nextForm = new InspectorForm(user_id);
                    }
                    else
                    {
                        // на всякий случай, если роль неизвестна
                        MessageBox.Show("Неизвестная роль сотрудника.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (nextForm != null)
                {
                    nextForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Не удалось определить форму для пользователя.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обращении к базе данных: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_showPassword_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                // Скрываем пароль
                textBox_password.UseSystemPasswordChar = true;
                button_showPassword.Text = "*";
                isPasswordVisible = false;
            }
            else
            {
                // Показываем пароль
                textBox_password.UseSystemPasswordChar = false;
                button_showPassword.Text = "👁";
                isPasswordVisible = true;
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                button_login.PerformClick();
            }
        }

        private void textBox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                textBox_password.Focus();
            }
        }
    }
}