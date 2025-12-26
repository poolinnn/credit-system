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
    public partial class InspectorProcessedApplicationsForm : Form
    {
        public Action ReturnToInspectorForm; 
        private int _inspectorId;

        public InspectorProcessedApplicationsForm(int inspectorId)
        {
            InitializeComponent();
            _inspectorId = inspectorId;
            LoadProcessedApplications();
        }

        private void LoadProcessedApplications()
        {
            try
            {
                // загружаем обработанные заявки через представление
                string query = @"
                    SELECT 
                        record_id,
                        client_id,
                        client_fio,
                        client_phone,
                        credit_type,
                        requested_amount,
                        requested_term_months,
                        application_date,
                        status
                    FROM inspector_processed_applications_view
                    WHERE inspector_id = @inspector_id
                    ORDER BY application_date DESC;";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@inspector_id", _inspectorId);
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView_processed_applications.DataSource = dt;

                        // настройка заголовков столбцов
                        dataGridView_processed_applications.Columns["record_id"].HeaderText = "ID заявки";
                        dataGridView_processed_applications.Columns["client_id"].HeaderText = "ID клиента";
                        dataGridView_processed_applications.Columns["client_fio"].HeaderText = "ФИО клиента";
                        dataGridView_processed_applications.Columns["client_phone"].HeaderText = "Телефон";
                        dataGridView_processed_applications.Columns["credit_type"].HeaderText = "Тип кредита";
                        dataGridView_processed_applications.Columns["requested_amount"].HeaderText = "Запрашиваемая сумма";
                        dataGridView_processed_applications.Columns["requested_term_months"].HeaderText = "Срок (мес.)";
                        dataGridView_processed_applications.Columns["application_date"].HeaderText = "Дата подачи";
                        dataGridView_processed_applications.Columns["status"].HeaderText = "Статус";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке обработанных заявок: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReturnToInspectorForm?.Invoke();
            this.Close();
        }
    }
}