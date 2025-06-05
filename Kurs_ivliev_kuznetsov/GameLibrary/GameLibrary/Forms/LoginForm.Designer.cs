namespace GameLibraryDA
{
    partial class LoginForm
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
            TBLoginMail = new TextBox();
            TBLoginPassword = new TextBox();
            BTNLogin = new Button();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            BTNCreateAccount = new Button();
            SuspendLayout();
            // 
            // TBLoginMail
            // 
            TBLoginMail.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBLoginMail.Location = new Point(137, 55);
            TBLoginMail.Multiline = true;
            TBLoginMail.Name = "TBLoginMail";
            TBLoginMail.Size = new Size(193, 31);
            TBLoginMail.TabIndex = 40;
            TBLoginMail.Text = "AdminUSA";
            // 
            // TBLoginPassword
            // 
            TBLoginPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBLoginPassword.Location = new Point(137, 136);
            TBLoginPassword.Multiline = true;
            TBLoginPassword.Name = "TBLoginPassword";
            TBLoginPassword.Size = new Size(193, 32);
            TBLoginPassword.TabIndex = 38;
            TBLoginPassword.Text = "adminpass1";
            // 
            // BTNLogin
            // 
            BTNLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTNLogin.Location = new Point(137, 244);
            BTNLogin.Name = "BTNLogin";
            BTNLogin.Size = new Size(193, 43);
            BTNLogin.TabIndex = 37;
            BTNLogin.Text = "Войти";
            BTNLogin.UseVisualStyleBackColor = true;
            BTNLogin.Click += BTNLogin_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(212, 9);
            label7.Name = "label7";
            label7.Size = new Size(58, 23);
            label7.TabIndex = 33;
            label7.Text = "Логин";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(201, 101);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 32;
            label6.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(84, 384);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 41;
            label1.Text = "Нет аккаунта?";
            // 
            // BTNCreateAccount
            // 
            BTNCreateAccount.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTNCreateAccount.Location = new Point(229, 379);
            BTNCreateAccount.Name = "BTNCreateAccount";
            BTNCreateAccount.Size = new Size(193, 33);
            BTNCreateAccount.TabIndex = 42;
            BTNCreateAccount.Text = "Создайте аккаунт";
            BTNCreateAccount.UseVisualStyleBackColor = true;
            BTNCreateAccount.Click += BTNCreateAccount_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 36);
            ClientSize = new Size(499, 435);
            Controls.Add(BTNCreateAccount);
            Controls.Add(label1);
            Controls.Add(TBLoginMail);
            Controls.Add(TBLoginPassword);
            Controls.Add(BTNLogin);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBLoginMail;
        private TextBox TBLoginPassword;
        private Button BTNLogin;
        private Label label7;
        private Label label6;
        private Label label1;
        private Button BTNCreateAccount;
    }
}