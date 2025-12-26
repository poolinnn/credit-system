namespace tr.Forms
{
    partial class AccountInfoForm
    {
        
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button_logout;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_contact = new System.Windows.Forms.Label();
            this.label_balance = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.label_debt = new System.Windows.Forms.Label();
            this.button_new_application = new System.Windows.Forms.Button();
            this.button_make_payment = new System.Windows.Forms.Button();
            this.button_profile_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_welcome.Location = new System.Drawing.Point(20, 20);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(280, 25);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Добро пожаловать, [ФИО]!";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(25, 310); 
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(200, 40);
            this.button_logout.TabIndex = 7;
            this.button_logout.Text = "Выйти";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Location = new System.Drawing.Point(20, 55);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(160, 16);
            this.label_contact.TabIndex = 1;
            this.label_contact.Text = "Тел: [телефон] | Паспорт: [серия] [номер]";
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(20, 90);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(150, 16);
            this.label_balance.TabIndex = 2;
            this.label_balance.Text = "Баланс: [баланс] руб.";
            // 
            // label_debt
            // 
            this.label_debt.AutoSize = true;
            this.label_debt.Location = new System.Drawing.Point(20, 120);
            this.label_debt.Name = "label_debt";
            this.label_debt.Size = new System.Drawing.Size(200, 16);
            this.label_debt.TabIndex = 3;
            this.label_debt.Text = "Общая задолженность: [задолженность] из [лимит] руб.";
            // 
            // button_new_application
            // 
            this.button_new_application.Location = new System.Drawing.Point(25, 160);
            this.button_new_application.Name = "button_new_application";
            this.button_new_application.Size = new System.Drawing.Size(200, 40);
            this.button_new_application.TabIndex = 4;
            this.button_new_application.Text = "Подать заявку на кредит";
            this.button_new_application.UseVisualStyleBackColor = true;
            this.button_new_application.Click += new System.EventHandler(this.button_new_application_Click);
            // 
            // button_make_payment
            // 
            this.button_make_payment.Location = new System.Drawing.Point(25, 210);
            this.button_make_payment.Name = "button_make_payment";
            this.button_make_payment.Size = new System.Drawing.Size(200, 40);
            this.button_make_payment.TabIndex = 5;
            this.button_make_payment.Text = "Внести платеж";
            this.button_make_payment.UseVisualStyleBackColor = true;
            this.button_make_payment.Click += new System.EventHandler(this.button_make_payment_Click);
            // 
            // button_profile_settings
            // 
            this.button_profile_settings.Location = new System.Drawing.Point(25, 260);
            this.button_profile_settings.Name = "button_profile_settings";
            this.button_profile_settings.Size = new System.Drawing.Size(200, 40);
            this.button_profile_settings.TabIndex = 6;
            this.button_profile_settings.Text = "Настройки профиля";
            this.button_profile_settings.UseVisualStyleBackColor = true;
            this.button_profile_settings.Click += new System.EventHandler(this.button_profile_settings_Click);
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_profile_settings);
            this.Controls.Add(this.button_make_payment);
            this.Controls.Add(this.button_new_application);
            this.Controls.Add(this.label_debt);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.label_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountInfoForm";
            this.Text = "Личный кабинет клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Label label_debt;
        private System.Windows.Forms.Button button_new_application;
        private System.Windows.Forms.Button button_make_payment;
        private System.Windows.Forms.Button button_profile_settings;
    }
}