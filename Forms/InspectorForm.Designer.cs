namespace tr.Forms
{
    partial class InspectorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_greeting;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button button_process_applications;
        private System.Windows.Forms.Button button_processed_applications;
        private System.Windows.Forms.Button button_logout;

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
            this.label_greeting = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.button_process_applications = new System.Windows.Forms.Button();
            this.button_processed_applications = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_greeting
            // 
            this.label_greeting.AutoSize = true;
            this.label_greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_greeting.Location = new System.Drawing.Point(20, 20);
            this.label_greeting.Name = "label_greeting";
            this.label_greeting.Size = new System.Drawing.Size(200, 25);
            this.label_greeting.TabIndex = 0;
            this.label_greeting.Text = "Здравствуйте, [ФИО]";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(20, 60);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(100, 16);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Сегодня: [дата]";
            // 
            // button_process_applications
            // 
            this.button_process_applications.Location = new System.Drawing.Point(25, 100);
            this.button_process_applications.Name = "button_process_applications";
            this.button_process_applications.Size = new System.Drawing.Size(300, 40);
            this.button_process_applications.TabIndex = 2;
            this.button_process_applications.Text = "Обработать заявки";
            this.button_process_applications.UseVisualStyleBackColor = true;
            this.button_process_applications.Click += new System.EventHandler(this.button_process_applications_Click);
            // 
            // button_processed_applications
            // 
            this.button_processed_applications.Location = new System.Drawing.Point(25, 150);
            this.button_processed_applications.Name = "button_processed_applications";
            this.button_processed_applications.Size = new System.Drawing.Size(300, 40);
            this.button_processed_applications.TabIndex = 3;
            this.button_processed_applications.Text = "Обработанные заявки";
            this.button_processed_applications.UseVisualStyleBackColor = true;
            this.button_processed_applications.Click += new System.EventHandler(this.button_processed_applications_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(25, 200);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(300, 40);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "Выйти";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // InspectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_processed_applications);
            this.Controls.Add(this.button_process_applications);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_greeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InspectorForm";
            this.Text = "Форма инспектора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}