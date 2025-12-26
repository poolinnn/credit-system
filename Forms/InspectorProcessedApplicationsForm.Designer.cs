namespace tr.Forms
{
    partial class InspectorProcessedApplicationsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dataGridView_processed_applications;
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
            this.dataGridView_processed_applications = new System.Windows.Forms.DataGridView();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_processed_applications)).BeginInit();
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
            this.label_title.Text = "Обработанные заявки";
            // 
            // dataGridView_processed_applications
            // 
            this.dataGridView_processed_applications.AllowUserToAddRows = false;
            this.dataGridView_processed_applications.AllowUserToDeleteRows = false;
            this.dataGridView_processed_applications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_processed_applications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_processed_applications.Location = new System.Drawing.Point(25, 60);
            this.dataGridView_processed_applications.Name = "dataGridView_processed_applications";
            this.dataGridView_processed_applications.ReadOnly = true;
            this.dataGridView_processed_applications.RowHeadersWidth = 51;
            this.dataGridView_processed_applications.Size = new System.Drawing.Size(700, 300);
            this.dataGridView_processed_applications.TabIndex = 1;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(25, 370);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 40);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Вернуться";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // InspectorProcessedApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 430);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridView_processed_applications);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InspectorProcessedApplicationsForm";
            this.Text = "Обработанные заявки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_processed_applications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}