namespace tr.Forms
{
    partial class AcceptClientApplicationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dataGridView_applications;
        private System.Windows.Forms.Label label_inspector;
        private System.Windows.Forms.ComboBox comboBox_inspector;
        private System.Windows.Forms.Button button_assign;
        private System.Windows.Forms.Button button_back;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.dataGridView_applications = new System.Windows.Forms.DataGridView();
            this.label_inspector = new System.Windows.Forms.Label();
            this.comboBox_inspector = new System.Windows.Forms.ComboBox();
            this.button_assign = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_applications)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(20, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(250, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Заявки от клиентов";
            // 
            // dataGridView_applications
            // 
            this.dataGridView_applications.AllowUserToAddRows = false;
            this.dataGridView_applications.AllowUserToDeleteRows = false;
            this.dataGridView_applications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_applications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_applications.Location = new System.Drawing.Point(25, 60);
            this.dataGridView_applications.Name = "dataGridView_applications";
            this.dataGridView_applications.ReadOnly = true;
            this.dataGridView_applications.RowHeadersWidth = 51;
            this.dataGridView_applications.Size = new System.Drawing.Size(700, 200);
            this.dataGridView_applications.TabIndex = 1;
            // 
            // label_inspector
            // 
            this.label_inspector.AutoSize = true;
            this.label_inspector.Location = new System.Drawing.Point(25, 280);
            this.label_inspector.Name = "label_inspector";
            this.label_inspector.Size = new System.Drawing.Size(110, 16);
            this.label_inspector.TabIndex = 2;
            this.label_inspector.Text = "Выбрать инспектора:";
            // 
            // comboBox_inspector
            // 
            this.comboBox_inspector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inspector.FormattingEnabled = true;
            this.comboBox_inspector.Location = new System.Drawing.Point(25, 300);
            this.comboBox_inspector.Name = "comboBox_inspector";
            this.comboBox_inspector.Size = new System.Drawing.Size(300, 24);
            this.comboBox_inspector.TabIndex = 3;
            // 
            // button_assign
            // 
            this.button_assign.Location = new System.Drawing.Point(25, 340);
            this.button_assign.Name = "button_assign";
            this.button_assign.Size = new System.Drawing.Size(150, 40);
            this.button_assign.TabIndex = 4;
            this.button_assign.Text = "Отправить инспектору";
            this.button_assign.UseVisualStyleBackColor = true;
            this.button_assign.Click += new System.EventHandler(this.button_assign_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(200, 340);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 40);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Вернуться";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // AcceptClientApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_assign);
            this.Controls.Add(this.comboBox_inspector);
            this.Controls.Add(this.label_inspector);
            this.Controls.Add(this.dataGridView_applications);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcceptClientApplicationForm";
            this.Text = "Принять заявку от клиента";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_applications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}