namespace GameLibraryDA.Forms
{
    partial class ReductForm
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
            CBRegistrationCountry = new ComboBox();
            TBRegistrationLogin = new TextBox();
            label8 = new Label();
            label5 = new Label();
            BTNCreateAccount = new Button();
            SuspendLayout();
            // 
            // CBRegistrationCountry
            // 
            CBRegistrationCountry.FormattingEnabled = true;
            CBRegistrationCountry.Location = new Point(36, 107);
            CBRegistrationCountry.Name = "CBRegistrationCountry";
            CBRegistrationCountry.Size = new Size(190, 23);
            CBRegistrationCountry.TabIndex = 35;
            // 
            // TBRegistrationLogin
            // 
            TBRegistrationLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBRegistrationLogin.Location = new Point(35, 40);
            TBRegistrationLogin.Multiline = true;
            TBRegistrationLogin.Name = "TBRegistrationLogin";
            TBRegistrationLogin.Size = new Size(193, 23);
            TBRegistrationLogin.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(54, 81);
            label8.Name = "label8";
            label8.Size = new Size(159, 23);
            label8.TabIndex = 33;
            label8.Text = "Страна проживания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(101, 5);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 32;
            label5.Text = "Логин";
            // 
            // BTNCreateAccount
            // 
            BTNCreateAccount.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTNCreateAccount.Location = new Point(36, 164);
            BTNCreateAccount.Name = "BTNCreateAccount";
            BTNCreateAccount.Size = new Size(193, 43);
            BTNCreateAccount.TabIndex = 36;
            BTNCreateAccount.Text = "Подтвердить";
            BTNCreateAccount.UseVisualStyleBackColor = true;
            BTNCreateAccount.Click += BTNCreateAccount_Click;
            // 
            // ReductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 36);
            ClientSize = new Size(263, 238);
            Controls.Add(BTNCreateAccount);
            Controls.Add(CBRegistrationCountry);
            Controls.Add(TBRegistrationLogin);
            Controls.Add(label8);
            Controls.Add(label5);
            Name = "ReductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBRegistrationCountry;
        private TextBox TBRegistrationLogin;
        private Label label8;
        private Label label5;
        private Button BTNCreateAccount;
    }
}