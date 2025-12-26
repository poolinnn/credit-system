namespace tr.Forms
{
    partial class InspectorApplicationsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dataGridView_applications;
        private System.Windows.Forms.Button button_approve;
        private System.Windows.Forms.Button button_reject;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Label label_comment;

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
            this.button_approve = new System.Windows.Forms.Button();
            this.button_reject = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.label_comment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_applications)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(20, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(200, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Заявки на проверке";
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
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(25, 280);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(130, 16);
            this.label_comment.TabIndex = 2;
            this.label_comment.Text = "Комментарий (опционально):";
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(25, 300);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(300, 22);
            this.textBox_comment.TabIndex = 3;
            // 
            // button_approve
            // 
            this.button_approve.Location = new System.Drawing.Point(25, 340);
            this.button_approve.Name = "button_approve";
            this.button_approve.Size = new System.Drawing.Size(100, 40);
            this.button_approve.TabIndex = 4;
            this.button_approve.Text = "Одобрить";
            this.button_approve.UseVisualStyleBackColor = true;
            this.button_approve.Click += new System.EventHandler(this.button_approve_Click);
            // 
            // button_reject
            // 
            this.button_reject.Location = new System.Drawing.Point(140, 340);
            this.button_reject.Name = "button_reject";
            this.button_reject.Size = new System.Drawing.Size(100, 40);
            this.button_reject.TabIndex = 5;
            this.button_reject.Text = "Отказать";
            this.button_reject.UseVisualStyleBackColor = true;
            this.button_reject.Click += new System.EventHandler(this.button_reject_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(255, 340);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 40);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "Вернуться";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // InspectorApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_reject);
            this.Controls.Add(this.button_approve);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.dataGridView_applications);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InspectorApplicationsForm";
            this.Text = "Обработать заявки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_applications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}