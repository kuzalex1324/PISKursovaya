namespace GameLibraryDA
{
    partial class AdministrationPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationPanelForm));
            BTNDeleteFeedback = new Button();
            GBAdminGames = new GroupBox();
            cbgames = new ComboBox();
            TBAdminGameSearch = new TextBox();
            label2 = new Label();
            GBFeedbacks = new GroupBox();
            label1 = new Label();
            LVAdminFeedbacks = new ListView();
            pictureBox1 = new PictureBox();
            player_name = new TextBox();
            label7 = new Label();
            BTNBan = new Button();
            button1 = new Button();
            GBAdminGames.SuspendLayout();
            GBFeedbacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTNDeleteFeedback
            // 
            BTNDeleteFeedback.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTNDeleteFeedback.ForeColor = SystemColors.ActiveCaptionText;
            BTNDeleteFeedback.Location = new Point(19, 292);
            BTNDeleteFeedback.Name = "BTNDeleteFeedback";
            BTNDeleteFeedback.Size = new Size(726, 31);
            BTNDeleteFeedback.TabIndex = 0;
            BTNDeleteFeedback.Text = "Удалить отзыв";
            BTNDeleteFeedback.UseVisualStyleBackColor = true;
            BTNDeleteFeedback.Click += BTNDeleteFeedback_Click;
            // 
            // GBAdminGames
            // 
            GBAdminGames.Controls.Add(cbgames);
            GBAdminGames.Controls.Add(TBAdminGameSearch);
            GBAdminGames.Controls.Add(label2);
            GBAdminGames.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GBAdminGames.ForeColor = SystemColors.ButtonHighlight;
            GBAdminGames.Location = new Point(12, 12);
            GBAdminGames.Name = "GBAdminGames";
            GBAdminGames.Size = new Size(234, 112);
            GBAdminGames.TabIndex = 20;
            GBAdminGames.TabStop = false;
            GBAdminGames.Text = "Игры";
            // 
            // cbgames
            // 
            cbgames.FormattingEnabled = true;
            cbgames.Location = new Point(6, 63);
            cbgames.Name = "cbgames";
            cbgames.Size = new Size(170, 31);
            cbgames.TabIndex = 36;
            cbgames.SelectedIndexChanged += cbgames_SelectedIndexChanged;
            // 
            // TBAdminGameSearch
            // 
            TBAdminGameSearch.Location = new Point(6, 27);
            TBAdminGameSearch.Name = "TBAdminGameSearch";
            TBAdminGameSearch.Size = new Size(170, 30);
            TBAdminGameSearch.TabIndex = 5;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(182, 30);
            label2.Name = "label2";
            label2.Size = new Size(32, 23);
            label2.TabIndex = 6;
            // 
            // GBFeedbacks
            // 
            GBFeedbacks.Controls.Add(label1);
            GBFeedbacks.Controls.Add(LVAdminFeedbacks);
            GBFeedbacks.Controls.Add(BTNDeleteFeedback);
            GBFeedbacks.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GBFeedbacks.ForeColor = SystemColors.ButtonHighlight;
            GBFeedbacks.Location = new Point(252, 12);
            GBFeedbacks.Name = "GBFeedbacks";
            GBFeedbacks.Size = new Size(758, 343);
            GBFeedbacks.TabIndex = 21;
            GBFeedbacks.TabStop = false;
            GBFeedbacks.Text = "Отзывы";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(726, 23);
            label1.TabIndex = 39;
            label1.Text = "Ник                          Текст                          Оценка                          Дата";
            // 
            // LVAdminFeedbacks
            // 
            LVAdminFeedbacks.BackColor = SystemColors.InactiveBorder;
            LVAdminFeedbacks.Location = new Point(19, 63);
            LVAdminFeedbacks.Name = "LVAdminFeedbacks";
            LVAdminFeedbacks.Size = new Size(726, 211);
            LVAdminFeedbacks.TabIndex = 18;
            LVAdminFeedbacks.UseCompatibleStateImageBehavior = false;
            LVAdminFeedbacks.View = View.List;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(877, 361);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 133);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // player_name
            // 
            player_name.Location = new Point(379, 410);
            player_name.Name = "player_name";
            player_name.Size = new Size(170, 28);
            player_name.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(435, 384);
            label7.Name = "label7";
            label7.Size = new Size(58, 23);
            label7.TabIndex = 34;
            label7.Text = "Логин";
            // 
            // BTNBan
            // 
            BTNBan.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTNBan.ForeColor = SystemColors.ActiveCaptionText;
            BTNBan.Location = new Point(290, 448);
            BTNBan.Name = "BTNBan";
            BTNBan.Size = new Size(170, 31);
            BTNBan.TabIndex = 19;
            BTNBan.Text = "Забанить игрока";
            BTNBan.UseVisualStyleBackColor = true;
            BTNBan.Click += BTNBan_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(466, 448);
            button1.Name = "button1";
            button1.Size = new Size(170, 31);
            button1.TabIndex = 35;
            button1.Text = "Разбанить игрока";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdministrationPanelForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 36);
            ClientSize = new Size(1045, 506);
            Controls.Add(button1);
            Controls.Add(BTNBan);
            Controls.Add(label7);
            Controls.Add(player_name);
            Controls.Add(pictureBox1);
            Controls.Add(GBFeedbacks);
            Controls.Add(GBAdminGames);
            Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "AdministrationPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministrationPanelForm";
            GBAdminGames.ResumeLayout(false);
            GBAdminGames.PerformLayout();
            GBFeedbacks.ResumeLayout(false);
            GBFeedbacks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNDeleteFeedback;
        private GroupBox GBAdminGames;
        private TextBox TBAdminGameSearch;
        private Label label2;
        private GroupBox GBFeedbacks;
        private ListView LVAdminFeedbacks;
        private PictureBox pictureBox1;
        private TextBox player_name;
        private Label label7;
        private Button BTNBan;
        private Button button1;
        private ComboBox cbgames;
        private Label label1;
    }
}