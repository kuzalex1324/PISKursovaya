namespace GameLibraryDA
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            BTNWriteFeedback = new Button();
            LVGames = new ListView();
            label2 = new Label();
            TBLibraryFormSearch = new TextBox();
            PBCurrentGame = new PictureBox();
            BTNInstallGame = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LabelNeedGB = new Label();
            LabelLastStart = new Label();
            LabelGameHours = new Label();
            GBFeedbacks = new GroupBox();
            label1 = new Label();
            LVFeedbacks = new ListView();
            GBAvailableGames = new GroupBox();
            BTNStart = new Button();
            ((System.ComponentModel.ISupportInitialize)PBCurrentGame).BeginInit();
            GBFeedbacks.SuspendLayout();
            GBAvailableGames.SuspendLayout();
            SuspendLayout();
            // 
            // BTNWriteFeedback
            // 
            BTNWriteFeedback.BackColor = SystemColors.InactiveBorder;
            BTNWriteFeedback.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BTNWriteFeedback.ForeColor = SystemColors.ControlText;
            BTNWriteFeedback.Location = new Point(19, 29);
            BTNWriteFeedback.Name = "BTNWriteFeedback";
            BTNWriteFeedback.Size = new Size(408, 37);
            BTNWriteFeedback.TabIndex = 0;
            BTNWriteFeedback.Text = "Написать отзыв";
            BTNWriteFeedback.UseVisualStyleBackColor = false;
            BTNWriteFeedback.Click += BTNWriteFeedback_Click;
            // 
            // LVGames
            // 
            LVGames.BackColor = SystemColors.InactiveBorder;
            LVGames.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LVGames.Location = new Point(6, 74);
            LVGames.MultiSelect = false;
            LVGames.Name = "LVGames";
            LVGames.Size = new Size(221, 483);
            LVGames.TabIndex = 3;
            LVGames.UseCompatibleStateImageBehavior = false;
            LVGames.View = View.List;
            LVGames.SelectedIndexChanged += LVGames_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(182, 30);
            label2.Name = "label2";
            label2.Size = new Size(32, 23);
            label2.TabIndex = 6;
            // 
            // TBLibraryFormSearch
            // 
            TBLibraryFormSearch.Location = new Point(6, 27);
            TBLibraryFormSearch.Name = "TBLibraryFormSearch";
            TBLibraryFormSearch.Size = new Size(170, 30);
            TBLibraryFormSearch.TabIndex = 5;
            // 
            // PBCurrentGame
            // 
            PBCurrentGame.Location = new Point(289, 12);
            PBCurrentGame.Name = "PBCurrentGame";
            PBCurrentGame.Size = new Size(815, 160);
            PBCurrentGame.SizeMode = PictureBoxSizeMode.StretchImage;
            PBCurrentGame.TabIndex = 7;
            PBCurrentGame.TabStop = false;
            // 
            // BTNInstallGame
            // 
            BTNInstallGame.BackColor = SystemColors.InactiveBorder;
            BTNInstallGame.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BTNInstallGame.Location = new Point(308, 178);
            BTNInstallGame.Name = "BTNInstallGame";
            BTNInstallGame.Size = new Size(146, 36);
            BTNInstallGame.TabIndex = 8;
            BTNInstallGame.Text = "↓ Установить";
            BTNInstallGame.UseVisualStyleBackColor = false;
            BTNInstallGame.Click += BTNInstallGame_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(501, 212);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 9;
            label3.Text = "Требуется места:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(736, 204);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 10;
            label4.Text = "Последний запуск:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(958, 204);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 11;
            label5.Text = "Вы играли:";
            // 
            // LabelNeedGB
            // 
            LabelNeedGB.AutoSize = true;
            LabelNeedGB.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelNeedGB.ForeColor = SystemColors.ButtonHighlight;
            LabelNeedGB.Location = new Point(639, 212);
            LabelNeedGB.Name = "LabelNeedGB";
            LabelNeedGB.Size = new Size(0, 23);
            LabelNeedGB.TabIndex = 12;
            // 
            // LabelLastStart
            // 
            LabelLastStart.AutoSize = true;
            LabelLastStart.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelLastStart.ForeColor = SystemColors.ButtonHighlight;
            LabelLastStart.Location = new Point(749, 227);
            LabelLastStart.Name = "LabelLastStart";
            LabelLastStart.Size = new Size(0, 23);
            LabelLastStart.TabIndex = 13;
            // 
            // LabelGameHours
            // 
            LabelGameHours.AutoSize = true;
            LabelGameHours.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelGameHours.ForeColor = SystemColors.ButtonHighlight;
            LabelGameHours.Location = new Point(958, 227);
            LabelGameHours.Name = "LabelGameHours";
            LabelGameHours.Size = new Size(0, 23);
            LabelGameHours.TabIndex = 14;
            // 
            // GBFeedbacks
            // 
            GBFeedbacks.Controls.Add(label1);
            GBFeedbacks.Controls.Add(LVFeedbacks);
            GBFeedbacks.Controls.Add(BTNWriteFeedback);
            GBFeedbacks.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GBFeedbacks.ForeColor = SystemColors.ButtonHighlight;
            GBFeedbacks.Location = new Point(289, 264);
            GBFeedbacks.Name = "GBFeedbacks";
            GBFeedbacks.Size = new Size(815, 331);
            GBFeedbacks.TabIndex = 18;
            GBFeedbacks.TabStop = false;
            GBFeedbacks.Text = "Отзывы";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(41, 75);
            label1.Name = "label1";
            label1.Size = new Size(726, 23);
            label1.TabIndex = 38;
            label1.Text = "Ник                          Текст                          Оценка                          Дата";
            // 
            // LVFeedbacks
            // 
            LVFeedbacks.BackColor = SystemColors.InactiveBorder;
            LVFeedbacks.Location = new Point(19, 101);
            LVFeedbacks.Name = "LVFeedbacks";
            LVFeedbacks.Size = new Size(778, 205);
            LVFeedbacks.TabIndex = 18;
            LVFeedbacks.UseCompatibleStateImageBehavior = false;
            LVFeedbacks.View = View.List;
            // 
            // GBAvailableGames
            // 
            GBAvailableGames.Controls.Add(LVGames);
            GBAvailableGames.Controls.Add(TBLibraryFormSearch);
            GBAvailableGames.Controls.Add(label2);
            GBAvailableGames.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GBAvailableGames.ForeColor = SystemColors.ButtonHighlight;
            GBAvailableGames.Location = new Point(12, 13);
            GBAvailableGames.Name = "GBAvailableGames";
            GBAvailableGames.Size = new Size(234, 582);
            GBAvailableGames.TabIndex = 19;
            GBAvailableGames.TabStop = false;
            GBAvailableGames.Text = "Доступные игры";
            // 
            // BTNStart
            // 
            BTNStart.BackColor = SystemColors.InactiveBorder;
            BTNStart.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BTNStart.Location = new Point(308, 227);
            BTNStart.Name = "BTNStart";
            BTNStart.Size = new Size(146, 36);
            BTNStart.TabIndex = 20;
            BTNStart.Text = "▶️ Запустить";
            BTNStart.UseVisualStyleBackColor = false;
            BTNStart.Click += BTNStart_Click;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 36);
            ClientSize = new Size(1116, 607);
            Controls.Add(BTNStart);
            Controls.Add(GBAvailableGames);
            Controls.Add(GBFeedbacks);
            Controls.Add(LabelGameHours);
            Controls.Add(LabelLastStart);
            Controls.Add(LabelNeedGB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BTNInstallGame);
            Controls.Add(PBCurrentGame);
            Name = "LibraryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibraryForm";
            ((System.ComponentModel.ISupportInitialize)PBCurrentGame).EndInit();
            GBFeedbacks.ResumeLayout(false);
            GBFeedbacks.PerformLayout();
            GBAvailableGames.ResumeLayout(false);
            GBAvailableGames.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNWriteFeedback;
        private ListView LVGames;
        private Label label2;
        private TextBox TBLibraryFormSearch;
        private PictureBox PBCurrentGame;
        private Button BTNInstallGame;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LabelNeedGB;
        private Label LabelLastStart;
        private Label LabelGameHours;
        private GroupBox GBFeedbacks;
        private GroupBox GBAvailableGames;
        private ListView LVFeedbacks;
        private Button BTNStart;
        private Label label1;
    }
}