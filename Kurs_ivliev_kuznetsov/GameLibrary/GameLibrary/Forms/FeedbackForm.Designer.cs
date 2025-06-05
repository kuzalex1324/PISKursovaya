namespace GameLibraryDA
{
    partial class FeedBackForm
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
            TBFeedback = new TextBox();
            LabelRating = new Label();
            numericUpDown1 = new NumericUpDown();
            BTNPublication = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // TBFeedback
            // 
            TBFeedback.BackColor = SystemColors.InactiveBorder;
            TBFeedback.Font = new Font("Comic Sans MS", 14.25F);
            TBFeedback.Location = new Point(29, 63);
            TBFeedback.Multiline = true;
            TBFeedback.Name = "TBFeedback";
            TBFeedback.Size = new Size(394, 254);
            TBFeedback.TabIndex = 0;
            // 
            // LabelRating
            // 
            LabelRating.AutoSize = true;
            LabelRating.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelRating.ForeColor = SystemColors.ButtonHighlight;
            LabelRating.Location = new Point(29, 362);
            LabelRating.Name = "LabelRating";
            LabelRating.Size = new Size(89, 27);
            LabelRating.TabIndex = 1;
            LabelRating.Text = "Оценка:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(31, 31, 36);
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown1.ForeColor = SystemColors.Window;
            numericUpDown1.Location = new Point(124, 361);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 34);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BTNPublication
            // 
            BTNPublication.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BTNPublication.Location = new Point(260, 361);
            BTNPublication.Name = "BTNPublication";
            BTNPublication.Size = new Size(163, 34);
            BTNPublication.TabIndex = 3;
            BTNPublication.Text = "Опубликовать";
            BTNPublication.UseVisualStyleBackColor = true;
            BTNPublication.Click += BTNPublication_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(144, 27);
            label1.TabIndex = 4;
            label1.Text = "Текст отзыва:";
            // 
            // FeedBackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 36);
            ClientSize = new Size(452, 426);
            Controls.Add(label1);
            Controls.Add(BTNPublication);
            Controls.Add(numericUpDown1);
            Controls.Add(LabelRating);
            Controls.Add(TBFeedback);
            Name = "FeedBackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FeedBackForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBFeedback;
        private Label LabelRating;
        private NumericUpDown numericUpDown1;
        private Button BTNPublication;
        private Label label1;
    }
}