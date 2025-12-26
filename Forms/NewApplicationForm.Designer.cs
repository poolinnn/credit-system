namespace tr.Forms
{
    partial class NewApplicationForm
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
            this.label_credit_type = new System.Windows.Forms.Label();
            this.comboBox_credit_type = new System.Windows.Forms.ComboBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label_term = new System.Windows.Forms.Label();
            this.numericUpDown_term = new System.Windows.Forms.NumericUpDown();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button(); // <<< Добавляем кнопку
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_term)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(20, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(210, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Новая заявка на кредит";
            // 
            // label_credit_type
            // 
            this.label_credit_type.AutoSize = true;
            this.label_credit_type.Location = new System.Drawing.Point(20, 60);
            this.label_credit_type.Name = "label_credit_type";
            this.label_credit_type.Size = new System.Drawing.Size(95, 16);
            this.label_credit_type.TabIndex = 1;
            this.label_credit_type.Text = "Тип кредита:";
            // 
            // comboBox_credit_type
            // 
            this.comboBox_credit_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_credit_type.FormattingEnabled = true;
            this.comboBox_credit_type.Location = new System.Drawing.Point(25, 80);
            this.comboBox_credit_type.Name = "comboBox_credit_type";
            this.comboBox_credit_type.Size = new System.Drawing.Size(300, 24);
            this.comboBox_credit_type.TabIndex = 2;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(20, 120);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(140, 16);
            this.label_amount.TabIndex = 3;
            this.label_amount.Text = "Запрашиваемая сумма:";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(25, 140);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(300, 22);
            this.textBox_amount.TabIndex = 4;
            // 
            // label_term
            // 
            this.label_term.AutoSize = true;
            this.label_term.Location = new System.Drawing.Point(20, 180);
            this.label_term.Name = "label_term";
            this.label_term.Size = new System.Drawing.Size(135, 16);
            this.label_term.TabIndex = 5;
            this.label_term.Text = "Запрашиваемый срок (мес.):";
            // 
            // numericUpDown_term
            // 
            this.numericUpDown_term.Location = new System.Drawing.Point(25, 200);
            this.numericUpDown_term.Minimum = 1;
            this.numericUpDown_term.Maximum = 360; // 30 лет
            this.numericUpDown_term.Name = "numericUpDown_term";
            this.numericUpDown_term.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_term.TabIndex = 6;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(25, 250);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(100, 40);
            this.button_submit.TabIndex = 7;
            this.button_submit.Text = "Отправить";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(140, 250);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(255, 250); // Пример координат
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 40);
            this.button_back.TabIndex = 9;
            this.button_back.Text = "Вернуться";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click); // <<< Подписываемся на событие
            // 
            // NewApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.button_back); // <<< Добавляем кнопку в форму
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.numericUpDown_term);
            this.Controls.Add(this.label_term);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.comboBox_credit_type);
            this.Controls.Add(this.label_credit_type);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewApplicationForm";
            this.Text = "Новая заявка";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_term)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_credit_type;
        private System.Windows.Forms.ComboBox comboBox_credit_type;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label_term;
        private System.Windows.Forms.NumericUpDown numericUpDown_term;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_back; // <<< Объявляем переменную
    }
}