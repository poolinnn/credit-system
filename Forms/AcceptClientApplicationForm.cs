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
    public partial class AcceptClientApplicationForm : Form
    {
        public Action ReturnToManageForm; 
        private int _managerId;

        public AcceptClientApplicationForm(int managerId)
        {
            InitializeComponent();
            _managerId = managerId;
            LoadApplications();
            LoadInspectors();
        }

        private void LoadApplications()
        {
            try
            {
             
                string query = @"
                    SELECT r.record_id, c.fio AS client_fio, c.phone, ct.name AS credit_type, r.requested_amount, r.requested_term_months, r.application_date
                    FROM records r
                    JOIN clients_data c ON r.client_id = c.client_id
                    JOIN credit_type ct ON r.credit_type_id = ct.credit_type_id
                    WHERE r.manager_id IS NULL AND r.status = 'на проверке'
                    ORDER BY r.application_date;";

                using (var command = new NpgsqlCommand(query, connection))
                {
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

        private void LoadInspectors()
        {
            try
            {
                // Загружаем инспекторов (role = 'inspector')
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

        private void button_assign_Click(object sender, EventArgs e)
        {
            if (dataGridView_applications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заявку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox_inspector.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите инспектора.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int recordId = (int)dataGridView_applications.SelectedRows[0].Cells["record_id"].Value;
            int inspectorId = Convert.ToInt32(comboBox_inspector.SelectedValue);

            try
            {
                string query = @"
                    UPDATE records
                    SET manager_id = @manager_id, inspector_id = @inspector_id
                    WHERE record_id = @record_id;";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@manager_id", _managerId);
                    command.Parameters.AddWithValue("@inspector_id", inspectorId);
                    command.Parameters.AddWithValue("@record_id", recordId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Заявка успешно отправлена инспектору!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadApplications(); // Обновляем список
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить заявку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при назначении заявки: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReturnToManageForm?.Invoke();
            this.Close();
        }
    }
}