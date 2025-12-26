using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using static tr.Globals;

namespace tr.Forms
{
    public partial class ManageForm : Form
    {
        private int _managerId;
        private string _managerFio;

        public ManageForm(int managerId)
        {
            InitializeComponent();
            _managerId = managerId;
            LoadManagerData();
        }

        private void LoadManagerData()
        {
            try
            {
                string query = "SELECT fio FROM employees_data WHERE employee_id = @manager_id;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@manager_id", _managerId);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        _managerFio = result.ToString();
                        label_greeting.Text = $"Здравствуйте, {_managerFio}";
                        label_date.Text = $"Сегодня: {DateTime.Today:dd.MM.yyyy}";
                    }
                    else
                    {
                        MessageBox.Show("Данные менеджера не найдены.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных менеджера: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button_accept_application_Click(object sender, EventArgs e)
        {
            // открыть форму для принятия заявки от клиента
            AcceptClientApplicationForm form = new AcceptClientApplicationForm(_managerId);
            form.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            var authForm = new AuthorizationForm();
            authForm.Show();
        }

        private void button_create_application_Click(object sender, EventArgs e)
        {
            // Открыть форму для создания заявки для нового клиента
            CreateApplicationForNewClientForm form = new CreateApplicationForNewClientForm(_managerId);
            form.Show();
        }

        private void button_my_records_Click(object sender, EventArgs e)
        {
            // Открыть форму для просмотра своих заявок
            MyRecordsForm form = new MyRecordsForm(_managerId);
            form.Show();
        }
    }
}