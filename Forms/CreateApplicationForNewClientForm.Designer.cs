namespace tr.Forms
{
    partial class CreateApplicationForNewClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_fio;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_passport_series;
        private System.Windows.Forms.TextBox textBox_passport_series;
        private System.Windows.Forms.Label label_passport_number;
        private System.Windows.Forms.TextBox textBox_passport_number;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_credit_type;
        private System.Windows.Forms.ComboBox comboBox_credit_type;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label_term;
        private System.Windows.Forms.NumericUpDown numericUpDown_term;
        private System.Windows.Forms.Label label_inspector;
        private System.Windows.Forms.ComboBox comboBox_inspector;
        private System.Windows.Forms.Button button_submit;
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
            this.label_fio = new System.Windows.Forms.Label();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_passport_series = new System.Windows.Forms.Label();
            this.textBox_passport_series = new System.Windows.Forms.TextBox();
            this.label_passport_number = new System.Windows.Forms.Label();
            this.textBox_passport_number = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_credit_type = new System.Windows.Forms.Label();
            this.comboBox_credit_type = new System.Windows.Forms.ComboBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label_term = new System.Windows.Forms.Label();
            this.numericUpDown_term = new System.Windows.Forms.NumericUpDown();
            this.label_inspector = new System.Windows.Forms.Label();
            this.comboBox_inspector = new System.Windows.Forms.ComboBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_term)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(20, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(280, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Создать заявку для нового клиента";
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
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_credit_type
            // 
            this.label_credit_type.AutoSize = true;
            this.label_credit_type.Location = new System.Drawing.Point(20, 310);
            this.label_credit_type.Name = "label_credit_type";
            this.label_credit_type.Size = new System.Drawing.Size(95, 16);
            this.label_credit_type.TabIndex = 13;
            this.label_credit_type.Text = "Тип кредита:";
            // 
            // comboBox_credit_type
            // 
            this.comboBox_credit_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_credit_type.FormattingEnabled = true;
            this.comboBox_credit_type.Location = new System.Drawing.Point(25, 330);
            this.comboBox_credit_type.Name = "comboBox_credit_type";
            this.comboBox_credit_type.Size = new System.Drawing.Size(300, 24);
            this.comboBox_credit_type.TabIndex = 14;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(20, 360);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(140, 16);
            this.label_amount.TabIndex = 15;
            this.label_amount.Text = "Запрашиваемая сумма:";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(25, 380);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(300, 22);
            this.textBox_amount.TabIndex = 16;
            // 
            // label_term
            // 
            this.label_term.AutoSize = true;
            this.label_term.Location = new System.Drawing.Point(20, 410);
            this.label_term.Name = "label_term";
            this.label_term.Size = new System.Drawing.Size(135, 16);
            this.label_term.TabIndex = 17;
            this.label_term.Text = "Запрашиваемый срок (мес.):";
            // 
            // numericUpDown_term
            // 
            this.numericUpDown_term.Location = new System.Drawing.Point(25, 430);
            this.numericUpDown_term.Minimum = 1;
            this.numericUpDown_term.Maximum = 360;
            this.numericUpDown_term.Name = "numericUpDown_term";
            this.numericUpDown_term.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_term.TabIndex = 18;
            // 
            // label_inspector
            // 
            this.label_inspector.AutoSize = true;
            this.label_inspector.Location = new System.Drawing.Point(20, 460);
            this.label_inspector.Name = "label_inspector";
            this.label_inspector.Size = new System.Drawing.Size(110, 16);
            this.label_inspector.TabIndex = 19;
            this.label_inspector.Text = "Выбрать инспектора:";
            // 
            // comboBox_inspector
            // 
            this.comboBox_inspector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inspector.FormattingEnabled = true;
            this.comboBox_inspector.Location = new System.Drawing.Point(25, 480);
            this.comboBox_inspector.Name = "comboBox_inspector";
            this.comboBox_inspector.Size = new System.Drawing.Size(300, 24);
            this.comboBox_inspector.TabIndex = 20;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(25, 520);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(150, 40);
            this.button_submit.TabIndex = 21;
            this.button_submit.Text = "Отправить инспектору";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(200, 520);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 40);
            this.button_back.TabIndex = 22;
            this.button_back.Text = "Вернуться";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // CreateApplicationForNewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 580);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.comboBox_inspector);
            this.Controls.Add(this.label_inspector);
            this.Controls.Add(this.numericUpDown_term);
            this.Controls.Add(this.label_term);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.comboBox_credit_type);
            this.Controls.Add(this.label_credit_type);
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
            this.Name = "CreateApplicationForNewClientForm";
            this.Text = "Создать заявку для нового клиента";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_term)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}