using Npgsql;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static tr.Globals;

namespace tr.Forms
{
    public partial class InspectorForm : Form
    {
        private int _inspectorId;
        private string _inspectorFio;

        public InspectorForm(int inspectorId)
        {
            InitializeComponent();
            _inspectorId = inspectorId;
            LoadInspectorData();
        }

        private void LoadInspectorData()
        {
            try
            {
                string query = "SELECT fio FROM employees_data WHERE employee_id = @inspector_id;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@inspector_id", _inspectorId);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        _inspectorFio = result.ToString();
                        label_greeting.Text = $"Здравствуйте, {_inspectorFio}";
                        label_date.Text = $"Сегодня: {DateTime.Today:dd.MM.yyyy}";
                    }
                    else
                    {
                        MessageBox.Show("Данные инспектора не найдены.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных инспектора: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button_process_applications_Click(object sender, EventArgs e)
        {
            // открыть форму для обработки заявок
            InspectorApplicationsForm form = new InspectorApplicationsForm(_inspectorId);
            form.Show();
        }

        private void button_processed_applications_Click(object sender, EventArgs e)
        {
            // открыть форму для просмотра обработанных заявок
            InspectorProcessedApplicationsForm form = new InspectorProcessedApplicationsForm(_inspectorId);
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