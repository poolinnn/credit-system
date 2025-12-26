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
    public partial class MyRecordsForm : Form
    {
        public Action ReturnToManageForm; 
        private int _managerId;

        public MyRecordsForm(int managerId)
        {
            InitializeComponent();
            _managerId = managerId;
            LoadRecords();
        }

        private void LoadRecords()
        {
            try
            {
                // вызов табличной функции, которую мы создали ранее
                string query = @"
                    SELECT 
                        record_id,
                        client_id,
                        fio,
                        phone,
                        requested_amount,
                        requested_term_months,
                        application_date,
                        status
                    FROM get_manager_records(@manager_id);";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@manager_id", _managerId);
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView_records.DataSource = dt;

                        // настройка столбцов
                        dataGridView_records.Columns["record_id"].HeaderText = "ID заявки";
                        dataGridView_records.Columns["client_id"].HeaderText = "ID клиента";
                        dataGridView_records.Columns["fio"].HeaderText = "ФИО клиента";
                        dataGridView_records.Columns["phone"].HeaderText = "Телефон";
                        dataGridView_records.Columns["requested_amount"].HeaderText = "Запрашиваемая сумма";
                        dataGridView_records.Columns["requested_term_months"].HeaderText = "Срок (мес.)";
                        dataGridView_records.Columns["application_date"].HeaderText = "Дата подачи";
                        dataGridView_records.Columns["status"].HeaderText = "Статус";
                    }
                }

                // применяем цвета строк
                ApplyRowColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявок: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ApplyRowColors()
        {
            foreach (DataGridViewRow row in dataGridView_records.Rows)
            {
                if (row.Cells["status"].Value != null)
                {
                    string status = row.Cells["status"].Value.ToString();

                    if (status == "на проверке")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen; // отправлено инспектору
                    }
                    else if (status == "на рассмотрении" || status == "новая") // примеры других статусов
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral; // не отправлено
                    }
                   
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReturnToManageForm?.Invoke();
            this.Close();
        }
    }
}