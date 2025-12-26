namespace tr.Forms
{
    partial class ProfileSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.label_fio = new System.Windows.Forms.Label();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_passport_series = new System.Windows.Forms.Label();
            this.textBox_passport_series = new System.Windows.Forms.TextBox();
            this.label_passport_number = new System.Windows.Forms.Label();
            this.textBox_passport_number = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
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
            this.label_title.Text = "Настройки профиля";
            // 
            // label_fio
            // 
            this.label_fio.AutoSize = true;
            this.label_fio.Location = new System.Drawing.Point(20, 60);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(42, 16);
            this.label_fio.TabIndex = 1;
            this.label_fio.Text = "ФИО:";
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(25, 80);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(300, 22);
            this.textBox_fio.TabIndex = 2;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(20, 110);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(67, 16);
            this.label_phone.TabIndex = 3;
            this.label_phone.Text = "Телефон:";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(25, 130);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(300, 22);
            this.textBox_phone.TabIndex = 4;
            // 
            // label_passport_series
            // 
            this.label_passport_series.AutoSize = true;
            this.label_passport_series.Location = new System.Drawing.Point(20, 160);
            this.label_passport_series.Name = "label_passport_series";
            this.label_passport_series.Size = new System.Drawing.Size(110, 16);
            this.label_passport_series.TabIndex = 5;
            this.label_passport_series.Text = "Серия паспорта:";
            // 
            // textBox_passport_series
            // 
            this.textBox_passport_series.Location = new System.Drawing.Point(25, 180);
            this.textBox_passport_series.Name = "textBox_passport_series";
            this.textBox_passport_series.Size = new System.Drawing.Size(100, 22);
            this.textBox_passport_series.TabIndex = 6;
            // 
            // label_passport_number
            // 
            this.label_passport_number.AutoSize = true;
            this.label_passport_number.Location = new System.Drawing.Point(140, 160);
            this.label_passport_number.Name = "label_passport_number";
            this.label_passport_number.Size = new System.Drawing.Size(120, 16);
            this.label_passport_number.TabIndex = 7;
            this.label_passport_number.Text = "Номер паспорта:";
            // 
            // textBox_passport_number
            // 
            this.textBox_passport_number.Location = new System.Drawing.Point(145, 180);
            this.textBox_passport_number.Name = "textBox_passport_number";
            this.textBox_passport_number.Size = new System.Drawing.Size(180, 22);
            this.textBox_passport_number.TabIndex = 8;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(20, 210);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(47, 16);
            this.label_login.TabIndex = 9;
            this.label_login.Text = "Логин:";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(25, 230);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(300, 22);
            this.textBox_login.TabIndex = 10;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(20, 260);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(57, 16);
            this.label_password.TabIndex = 11;
            this.label_password.Text = "Пароль:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(25, 280);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(300, 22);
            this.textBox_password.TabIndex = 12;
            this.textBox_password.UseSystemPasswordChar = true; // Скрыть пароль
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(25, 320);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 40);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(140, 320);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 40);
            this.button_back.TabIndex = 14;
            this.button_back.Text = "Вернуться";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // ProfileSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_passport_number);
            this.Controls.Add(this.label_passport_number);
            this.Controls.Add(this.textBox_passport_series);
            this.Controls.Add(this.label_passport_series);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.textBox_fio);
            this.Controls.Add(this.label_fio);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileSettingsForm";
            this.Text = "Настройки профиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_fio;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_passport_series;
        private System.Windows.Forms.TextBox textBox_passport_series;
        private System.Windows.Forms.Label label_passport_number;
        private System.Windows.Forms.TextBox textBox_passport_number;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
    }
}