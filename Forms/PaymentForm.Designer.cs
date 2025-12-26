namespace tr.Forms
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button_back;

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
            this.label_contract = new System.Windows.Forms.Label();
            this.comboBox_contract = new System.Windows.Forms.ComboBox();
            this.button_back = new System.Windows.Forms.Button();
            this.label_amount = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_contract_info = new System.Windows.Forms.Label();
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
            this.label_title.Text = "Внести платеж";
            // 

            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(25, 310); // Пример координат
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 40);
            this.button_back.TabIndex = 10;
            this.button_back.Text = "Вернуться";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);

            // label_contract
            // 
            this.label_contract.AutoSize = true;
            this.label_contract.Location = new System.Drawing.Point(20, 60);
            this.label_contract.Name = "label_contract";
            this.label_contract.Size = new System.Drawing.Size(110, 16);
            this.label_contract.TabIndex = 1;
            this.label_contract.Text = "Номер договора:";
            // 
            // comboBox_contract
            // 
            this.comboBox_contract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_contract.FormattingEnabled = true;
            this.comboBox_contract.Location = new System.Drawing.Point(25, 80);
            this.comboBox_contract.Name = "comboBox_contract";
            this.comboBox_contract.Size = new System.Drawing.Size(300, 24);
            this.comboBox_contract.TabIndex = 2;
            this.comboBox_contract.SelectedIndexChanged += new System.EventHandler(this.comboBox_contract_SelectedIndexChanged);
            // 
            // label_contract_info
            // 
            this.label_contract_info.AutoSize = true;
            this.label_contract_info.Location = new System.Drawing.Point(25, 110);
            this.label_contract_info.Name = "label_contract_info";
            this.label_contract_info.Size = new System.Drawing.Size(0, 16);
            this.label_contract_info.TabIndex = 3;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(20, 140);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(140, 16);
            this.label_amount.TabIndex = 4;
            this.label_amount.Text = "Сумма платежа:";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(25, 160);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(300, 22);
            this.textBox_amount.TabIndex = 5;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(20, 200);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(120, 16);
            this.label_date.TabIndex = 6;
            this.label_date.Text = "Дата платежа:";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_date.Location = new System.Drawing.Point(25, 220);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(150, 22);
            this.dateTimePicker_date.TabIndex = 7;
            this.dateTimePicker_date.Value = DateTime.Today;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(25, 260);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(100, 40);
            this.button_submit.TabIndex = 8;
            this.button_submit.Text = "Отправить";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(140, 260);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_back
// 
this.button_back = new System.Windows.Forms.Button();
this.button_back.Location = new System.Drawing.Point(25, 310);
this.button_back.Name = "button_back";
this.button_back.Size = new System.Drawing.Size(100, 40);
this.button_back.TabIndex = 9;
this.button_back.Text = "Вернуться";
this.button_back.UseVisualStyleBackColor = true;
this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_contract_info);
            this.Controls.Add(this.comboBox_contract);
            this.Controls.Add(this.label_contract);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.Text = "Внести платеж";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_contract;
        private System.Windows.Forms.ComboBox comboBox_contract;
        private System.Windows.Forms.Label label_contract_info;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_cancel;
    }
}