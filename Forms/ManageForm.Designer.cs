namespace tr.Forms
{
    partial class ManageForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_greeting;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button button_accept_application;
        private System.Windows.Forms.Button button_create_application;
        private System.Windows.Forms.Button button_my_records;
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
            this.button_accept_application = new System.Windows.Forms.Button();
            this.button_create_application = new System.Windows.Forms.Button();
            this.button_my_records = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            this.button_logout = new System.Windows.Forms.Button();
            this.button_logout.Location = new System.Drawing.Point(25, 250); 
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(300, 40);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Выйти";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
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
            // button_accept_application
            // 
            this.button_accept_application.Location = new System.Drawing.Point(25, 100);
            this.button_accept_application.Name = "button_accept_application";
            this.button_accept_application.Size = new System.Drawing.Size(300, 40);
            this.button_accept_application.TabIndex = 2;
            this.button_accept_application.Text = "Принять заявку от клиента";
            this.button_accept_application.UseVisualStyleBackColor = true;
            this.button_accept_application.Click += new System.EventHandler(this.button_accept_application_Click);
            // 
            // button_create_application
            // 
            this.button_create_application.Location = new System.Drawing.Point(25, 150);
            this.button_create_application.Name = "button_create_application";
            this.button_create_application.Size = new System.Drawing.Size(300, 40);
            this.button_create_application.TabIndex = 3;
            this.button_create_application.Text = "Создать заявку для нового клиента";
            this.button_create_application.UseVisualStyleBackColor = true;
            this.button_create_application.Click += new System.EventHandler(this.button_create_application_Click);
            // 
            // button_my_records
            // 
            this.button_my_records.Location = new System.Drawing.Point(25, 200);
            this.button_my_records.Name = "button_my_records";
            this.button_my_records.Size = new System.Drawing.Size(300, 40);
            this.button_my_records.TabIndex = 4;
            this.button_my_records.Text = "Мои заявки";
            this.button_my_records.UseVisualStyleBackColor = true;
            this.button_my_records.Click += new System.EventHandler(this.button_my_records_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_my_records);
            this.Controls.Add(this.button_create_application);
            this.Controls.Add(this.button_accept_application);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_greeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageForm";
            this.Text = "Форма менеджера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}