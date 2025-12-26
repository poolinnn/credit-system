namespace tr.Forms
{
    partial class MyRecordsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dataGridView_records;
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
            this.dataGridView_records = new System.Windows.Forms.DataGridView();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_records)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(20, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(180, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Мои заявки";
            // 
            // dataGridView_records
            // 
            this.dataGridView_records.AllowUserToAddRows = false;
            this.dataGridView_records.AllowUserToDeleteRows = false;
            this.dataGridView_records.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_records.Location = new System.Drawing.Point(25, 60);
            this.dataGridView_records.Name = "dataGridView_records";
            this.dataGridView_records.ReadOnly = true;
            this.dataGridView_records.RowHeadersWidth = 51;
            this.dataGridView_records.Size = new System.Drawing.Size(800, 350);
            this.dataGridView_records.TabIndex = 1;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(25, 420);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 40);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Вернуться";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // MyRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridView_records);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyRecordsForm";
            this.Text = "Мои заявки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_records)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}