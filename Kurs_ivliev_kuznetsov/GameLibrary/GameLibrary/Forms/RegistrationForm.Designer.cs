namespace GameLibraryDA
{
    partial class RegistrationForm
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BTNCreateAccount = new Button();
            TBRegistrationPassword = new TextBox();
            TBRegistrationLogin = new TextBox();
            TBRegistrationMail = new TextBox();
            CBRegistrationCountry = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(216, 107);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 19;
            label5.Text = "Логин";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(214, 193);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 21;
            label6.Text = "Пароль";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(140, 18);
            label7.Name = "label7";
            label7.Size = new Size(212, 23);
            label7.TabIndex = 23;
            label7.Text = "Адрес электронной почты";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(171, 286);
            label8.Name = "label8";
            label8.Size = new Size(159, 23);
            label8.TabIndex = 25;
            label8.Text = "Страна проживания";
            // 
            // BTNCreateAccount
            // 
            BTNCreateAccount.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTNCreateAccount.Location = new Point(150, 424);
            BTNCreateAccount.Name = "BTNCreateAccount";
            BTNCreateAccount.Size = new Size(193, 43);
            BTNCreateAccount.TabIndex = 27;
            BTNCreateAccount.Text = "Создать аккаунт";
            BTNCreateAccount.UseVisualStyleBackColor = true;
            BTNCreateAccount.Click += BTNCreateAccount_Click;
            // 
            // TBRegistrationPassword
            // 
            TBRegistrationPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBRegistrationPassword.Location = new Point(150, 228);
            TBRegistrationPassword.Multiline = true;
            TBRegistrationPassword.Name = "TBRegistrationPassword";
            TBRegistrationPassword.Size = new Size(193, 23);
            TBRegistrationPassword.TabIndex = 28;
            // 
            // TBRegistrationLogin
            // 
            TBRegistrationLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBRegistrationLogin.Location = new Point(150, 142);
            TBRegistrationLogin.Multiline = true;
            TBRegistrationLogin.Name = "TBRegistrationLogin";
            TBRegistrationLogin.Size = new Size(193, 23);
            TBRegistrationLogin.TabIndex = 29;
            // 
            // TBRegistrationMail
            // 
            TBRegistrationMail.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBRegistrationMail.Location = new Point(150, 58);
            TBRegistrationMail.Multiline = true;
            TBRegistrationMail.Name = "TBRegistrationMail";
            TBRegistrationMail.Size = new Size(193, 23);
            TBRegistrationMail.TabIndex = 30;
            // 
            // CBRegistrationCountry
            // 
            CBRegistrationCountry.FormattingEnabled = true;
            CBRegistrationCountry.Location = new Point(153, 312);
            CBRegistrationCountry.Name = "CBRegistrationCountry";
            CBRegistrationCountry.Size = new Size(190, 23);
            CBRegistrationCountry.TabIndex = 31;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 36);
            ClientSize = new Size(496, 505);
            Controls.Add(CBRegistrationCountry);
            Controls.Add(TBRegistrationMail);
            Controls.Add(TBRegistrationLogin);
            Controls.Add(TBRegistrationPassword);
            Controls.Add(BTNCreateAccount);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelStatus;
        private Label label4;
        private Label LabelUserName;
        private Button BTNEditForm;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TBRegistrationMail;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private Button BTNCreateAccount;
        private TextBox TBRegistrationPassword;
        private TextBox TBRegistrationLogin;
        private ComboBox CBRegistrationCountry;
    }
}