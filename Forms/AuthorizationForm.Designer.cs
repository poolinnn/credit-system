
namespace tr.Forms
{
    partial class AuthorizationForm
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
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.button_showPassword = new System.Windows.Forms.Button(); // Объявляем кнопку
            this.SuspendLayout();
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(197, 156);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 16);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "Пароль";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(197, 81);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(46, 16);
            this.label_login.TabIndex = 8;
            this.label_login.Text = "Логин";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(200, 100);
            this.textBox_login.MaxLength = 20;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(200, 22);
            this.textBox_login.TabIndex = 0;
            this.textBox_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_login_KeyPress);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(200, 175);
            this.textBox_password.MaxLength = 20;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(200, 22);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.UseSystemPasswordChar = true; // Скрываем пароль
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_password_KeyPress);
            // 
            // button_showPassword
            // 
            this.button_showPassword.Location = new System.Drawing.Point(410, 175);
            this.button_showPassword.Name = "button_showPassword";
            this.button_showPassword.Size = new System.Drawing.Size(25, 22);
            this.button_showPassword.Text = "*";
            this.button_showPassword.UseVisualStyleBackColor = true;
            this.button_showPassword.Click += new System.EventHandler(this.button_showPassword_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(222, 242);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(150, 40);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.button_showPassword); // Добавляем кнопку
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button button_showPassword; // Объявляем переменную
    }
}