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
    public partial class InspectorApplicationsForm : Form
    {
        public Action ReturnToInspectorForm; 
        private int _inspectorId;

        public InspectorApplicationsForm(int inspectorId)
        {
            InitializeComponent();
            _inspectorId = inspectorId;
            LoadApplications();
        }

        private void LoadApplications()
        {
            try
            {
                // загружаем заявки, где inspector_id = текущему инспектору и status = 'на проверке'
                string query = @"
                    SELECT r.record_id, c.fio AS client_fio, c.phone, ct.name AS credit_type, r.requested_amount, r.requested_term_months, r.application_date
                    FROM records r
                    JOIN clients_data c ON r.client_id = c.client_id
                    JOIN credit_type ct ON r.credit_type_id = ct.credit_type_id
                    WHERE r.inspector_id = @inspector_id AND r.status = 'на проверке'
                    ORDER BY r.application_date;";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@inspector_id", _inspectorId);
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView_applications.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявок: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button_approve_Click(object sender, EventArgs e)
        {
            ProcessApplication("одобрено");
        }

        private void button_reject_Click(object sender, EventArgs e)
        {
            ProcessApplication("отказано");
        }

        private void ProcessApplication(string newStatus)
        {
            if (dataGridView_applications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заявку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int recordId = (int)dataGridView_applications.SelectedRows[0].Cells["record_id"].Value;

            try
            {
                string query = @"
            UPDATE records
            SET status = @status
            WHERE record_id = @record_id;";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@status", newStatus);
                    command.Parameters.AddWithValue("@record_id", recordId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Заявка успешно {newStatus}!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadApplications(); // обновляем список
                        textBox_comment.Clear(); // очищаем комментарий
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить заявку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке заявки: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReturnToInspectorForm?.Invoke();
            this.Close();
        }
    }
}