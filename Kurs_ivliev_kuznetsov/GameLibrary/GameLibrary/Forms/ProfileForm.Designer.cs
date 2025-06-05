namespace GameLibraryDA
{
    partial class ProfileForm
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
            PBUser = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            BTNEditForm = new Button();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            LabelUserName = new Label();
            LabelCountry = new Label();
            ((System.ComponentModel.ISupportInitialize)PBUser).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PBUser
            // 
            PBUser.Image = Properties.Resources.profile;
            PBUser.InitialImage = Properties.Resources.profile;
            PBUser.Location = new Point(77, 25);
            PBUser.Name = "PBUser";
            PBUser.Size = new Size(197, 163);
            PBUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PBUser.TabIndex = 0;
            PBUser.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(302, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 1;
            label1.Text = "Ник:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(302, 63);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 2;
            label2.Text = "Страна:";
            // 
            // BTNEditForm
            // 
            BTNEditForm.BackColor = SystemColors.InactiveBorder;
            BTNEditForm.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTNEditForm.Location = new Point(305, 153);
            BTNEditForm.Name = "BTNEditForm";
            BTNEditForm.Size = new Size(203, 35);
            BTNEditForm.TabIndex = 4;
            BTNEditForm.Text = "Редактировать";
            BTNEditForm.UseVisualStyleBackColor = false;
            BTNEditForm.Click += BTNEditForm_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(26, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 291);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Игры";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveBorder;
            listView1.Location = new Point(6, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(512, 256);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // LabelUserName
            // 
            LabelUserName.AutoSize = true;
            LabelUserName.Font = new Font("Comic Sans MS", 12F);
            LabelUserName.ForeColor = SystemColors.ButtonHighlight;
            LabelUserName.Location = new Point(344, 25);
            LabelUserName.Name = "LabelUserName";
            LabelUserName.Size = new Size(54, 23);
            LabelUserName.TabIndex = 6;
            LabelUserName.Text = "Sanuk";
            // 
            // LabelCountry
            // 
            LabelCountry.AutoSize = true;
            LabelCountry.Font = new Font("Comic Sans MS", 12F);
            LabelCountry.ForeColor = SystemColors.ButtonHighlight;
            LabelCountry.Location = new Point(370, 63);
            LabelCountry.Name = "LabelCountry";
            LabelCountry.Size = new Size(56, 23);
            LabelCountry.TabIndex = 7;
            LabelCountry.Text = "Russia";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 36);
            ClientSize = new Size(581, 522);
            Controls.Add(LabelCountry);
            Controls.Add(LabelUserName);
            Controls.Add(groupBox1);
            Controls.Add(BTNEditForm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PBUser);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)PBUser).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBUser;
        private Label label1;
        private Label label2;
        private Button BTNEditForm;
        private GroupBox groupBox1;
        private ListView listView1;
        private Label LabelUserName;
        private Label LabelCountry;
    }
}