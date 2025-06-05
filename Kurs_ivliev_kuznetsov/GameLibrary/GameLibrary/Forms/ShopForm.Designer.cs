namespace GameLibraryDA
{
    partial class ShopForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            BTNShop = new Button();
            BTNLibrary = new Button();
            BTNProfile = new Button();
            label1 = new Label();
            PBLargePhoto = new PictureBox();
            PBSmallPhotoTopLeft = new PictureBox();
            PBSmallPhotoTopRight = new PictureBox();
            PBSmallPhotoBottomLeft = new PictureBox();
            PBSmallPhotoBottomRight = new PictureBox();
            LabelNameOfGame = new Label();
            LabelGenreOfGame = new Label();
            groupBox1 = new GroupBox();
            GBGamesForBuying = new GroupBox();
            CBShopFormSearch = new ComboBox();
            LabelPrice = new Label();
            BTNBuy = new Button();
            LabelGameGenre = new Label();
            LabelGameName = new Label();
            GBBalance = new GroupBox();
            LabelBalance = new Label();
            ((System.ComponentModel.ISupportInitialize)PBLargePhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBSmallPhotoTopLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBSmallPhotoTopRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBSmallPhotoBottomLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBSmallPhotoBottomRight).BeginInit();
            groupBox1.SuspendLayout();
            GBGamesForBuying.SuspendLayout();
            GBBalance.SuspendLayout();
            SuspendLayout();
            // 
            // BTNShop
            // 
            BTNShop.BackColor = Color.Transparent;
            BTNShop.Cursor = Cursors.Hand;
            BTNShop.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            BTNShop.ForeColor = SystemColors.ActiveCaptionText;
            BTNShop.Location = new Point(39, 44);
            BTNShop.Name = "BTNShop";
            BTNShop.Size = new Size(138, 43);
            BTNShop.TabIndex = 0;
            BTNShop.Text = "Магазин";
            BTNShop.UseVisualStyleBackColor = false;
            // 
            // BTNLibrary
            // 
            BTNLibrary.BackColor = Color.Transparent;
            BTNLibrary.Cursor = Cursors.Hand;
            BTNLibrary.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            BTNLibrary.ForeColor = SystemColors.ActiveCaptionText;
            BTNLibrary.Location = new Point(225, 44);
            BTNLibrary.Name = "BTNLibrary";
            BTNLibrary.Size = new Size(162, 43);
            BTNLibrary.TabIndex = 1;
            BTNLibrary.Text = "Библиотека";
            BTNLibrary.UseVisualStyleBackColor = false;
            BTNLibrary.Click += BTNLibrary_Click;
            // 
            // BTNProfile
            // 
            BTNProfile.BackColor = Color.Transparent;
            BTNProfile.Cursor = Cursors.Hand;
            BTNProfile.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            BTNProfile.ForeColor = SystemColors.ActiveCaptionText;
            BTNProfile.Location = new Point(454, 44);
            BTNProfile.Name = "BTNProfile";
            BTNProfile.Size = new Size(162, 43);
            BTNProfile.TabIndex = 2;
            BTNProfile.Text = "Профиль";
            BTNProfile.UseVisualStyleBackColor = false;
            BTNProfile.Click += BTNProfile_Click;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(977, 29);
            label1.Name = "label1";
            label1.Size = new Size(32, 23);
            label1.TabIndex = 4;
            // 
            // PBLargePhoto
            // 
            PBLargePhoto.Image = Properties.Resources.error;
            PBLargePhoto.ImageLocation = "";
            PBLargePhoto.InitialImage = null;
            PBLargePhoto.Location = new Point(16, 77);
            PBLargePhoto.Name = "PBLargePhoto";
            PBLargePhoto.Size = new Size(471, 450);
            PBLargePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            PBLargePhoto.TabIndex = 6;
            PBLargePhoto.TabStop = false;
            // 
            // PBSmallPhotoTopLeft
            // 
            PBSmallPhotoTopLeft.BorderStyle = BorderStyle.FixedSingle;
            PBSmallPhotoTopLeft.Image = Properties.Resources.error;
            PBSmallPhotoTopLeft.Location = new Point(512, 185);
            PBSmallPhotoTopLeft.Name = "PBSmallPhotoTopLeft";
            PBSmallPhotoTopLeft.Size = new Size(250, 158);
            PBSmallPhotoTopLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            PBSmallPhotoTopLeft.TabIndex = 7;
            PBSmallPhotoTopLeft.TabStop = false;
            // 
            // PBSmallPhotoTopRight
            // 
            PBSmallPhotoTopRight.BorderStyle = BorderStyle.FixedSingle;
            PBSmallPhotoTopRight.Image = Properties.Resources.error;
            PBSmallPhotoTopRight.Location = new Point(802, 185);
            PBSmallPhotoTopRight.Name = "PBSmallPhotoTopRight";
            PBSmallPhotoTopRight.Size = new Size(250, 158);
            PBSmallPhotoTopRight.SizeMode = PictureBoxSizeMode.StretchImage;
            PBSmallPhotoTopRight.TabIndex = 8;
            PBSmallPhotoTopRight.TabStop = false;
            // 
            // PBSmallPhotoBottomLeft
            // 
            PBSmallPhotoBottomLeft.BorderStyle = BorderStyle.FixedSingle;
            PBSmallPhotoBottomLeft.Image = Properties.Resources.error;
            PBSmallPhotoBottomLeft.Location = new Point(512, 368);
            PBSmallPhotoBottomLeft.Name = "PBSmallPhotoBottomLeft";
            PBSmallPhotoBottomLeft.Size = new Size(250, 158);
            PBSmallPhotoBottomLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            PBSmallPhotoBottomLeft.TabIndex = 9;
            PBSmallPhotoBottomLeft.TabStop = false;
            // 
            // PBSmallPhotoBottomRight
            // 
            PBSmallPhotoBottomRight.BorderStyle = BorderStyle.FixedSingle;
            PBSmallPhotoBottomRight.Image = Properties.Resources.error;
            PBSmallPhotoBottomRight.InitialImage = Properties.Resources.error;
            PBSmallPhotoBottomRight.Location = new Point(802, 368);
            PBSmallPhotoBottomRight.Name = "PBSmallPhotoBottomRight";
            PBSmallPhotoBottomRight.Size = new Size(250, 158);
            PBSmallPhotoBottomRight.SizeMode = PictureBoxSizeMode.StretchImage;
            PBSmallPhotoBottomRight.TabIndex = 10;
            PBSmallPhotoBottomRight.TabStop = false;
            // 
            // LabelNameOfGame
            // 
            LabelNameOfGame.AutoSize = true;
            LabelNameOfGame.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelNameOfGame.ForeColor = SystemColors.ButtonHighlight;
            LabelNameOfGame.Location = new Point(512, 82);
            LabelNameOfGame.Name = "LabelNameOfGame";
            LabelNameOfGame.Size = new Size(137, 23);
            LabelNameOfGame.TabIndex = 11;
            LabelNameOfGame.Text = "Название игры:";
            // 
            // LabelGenreOfGame
            // 
            LabelGenreOfGame.AutoSize = true;
            LabelGenreOfGame.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelGenreOfGame.ForeColor = SystemColors.ButtonHighlight;
            LabelGenreOfGame.Location = new Point(512, 124);
            LabelGenreOfGame.Name = "LabelGenreOfGame";
            LabelGenreOfGame.Size = new Size(105, 23);
            LabelGenreOfGame.TabIndex = 12;
            LabelGenreOfGame.Text = "Жанр игры:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BTNLibrary);
            groupBox1.Controls.Add(BTNShop);
            groupBox1.Controls.Add(BTNProfile);
            groupBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(665, 130);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Навигация";
            // 
            // GBGamesForBuying
            // 
            GBGamesForBuying.Controls.Add(CBShopFormSearch);
            GBGamesForBuying.Controls.Add(LabelPrice);
            GBGamesForBuying.Controls.Add(BTNBuy);
            GBGamesForBuying.Controls.Add(LabelGameGenre);
            GBGamesForBuying.Controls.Add(LabelGameName);
            GBGamesForBuying.Controls.Add(PBSmallPhotoTopLeft);
            GBGamesForBuying.Controls.Add(PBSmallPhotoTopRight);
            GBGamesForBuying.Controls.Add(PBLargePhoto);
            GBGamesForBuying.Controls.Add(LabelGenreOfGame);
            GBGamesForBuying.Controls.Add(PBSmallPhotoBottomLeft);
            GBGamesForBuying.Controls.Add(label1);
            GBGamesForBuying.Controls.Add(LabelNameOfGame);
            GBGamesForBuying.Controls.Add(PBSmallPhotoBottomRight);
            GBGamesForBuying.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GBGamesForBuying.ForeColor = SystemColors.ButtonHighlight;
            GBGamesForBuying.Location = new Point(12, 167);
            GBGamesForBuying.Name = "GBGamesForBuying";
            GBGamesForBuying.Size = new Size(1069, 544);
            GBGamesForBuying.TabIndex = 14;
            GBGamesForBuying.TabStop = false;
            GBGamesForBuying.Text = "Игры";
            // 
            // CBShopFormSearch
            // 
            CBShopFormSearch.FormattingEnabled = true;
            CBShopFormSearch.Location = new Point(798, 26);
            CBShopFormSearch.Name = "CBShopFormSearch";
            CBShopFormSearch.Size = new Size(173, 31);
            CBShopFormSearch.TabIndex = 17;
            CBShopFormSearch.SelectedIndexChanged += CBShopFormSearch_SelectedIndexChanged;
            // 
            // LabelPrice
            // 
            LabelPrice.AutoSize = true;
            LabelPrice.Location = new Point(934, 128);
            LabelPrice.Name = "LabelPrice";
            LabelPrice.Size = new Size(0, 23);
            LabelPrice.TabIndex = 16;
            // 
            // BTNBuy
            // 
            BTNBuy.BackColor = Color.Transparent;
            BTNBuy.Cursor = Cursors.Hand;
            BTNBuy.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            BTNBuy.ForeColor = SystemColors.ActiveCaptionText;
            BTNBuy.Location = new Point(889, 82);
            BTNBuy.Name = "BTNBuy";
            BTNBuy.Size = new Size(138, 43);
            BTNBuy.TabIndex = 15;
            BTNBuy.Text = "Купить";
            BTNBuy.UseVisualStyleBackColor = false;
            BTNBuy.Click += BTNBuy_Click;
            // 
            // LabelGameGenre
            // 
            LabelGameGenre.AutoSize = true;
            LabelGameGenre.Location = new Point(625, 124);
            LabelGameGenre.Name = "LabelGameGenre";
            LabelGameGenre.Size = new Size(0, 23);
            LabelGameGenre.TabIndex = 14;
            // 
            // LabelGameName
            // 
            LabelGameName.AutoSize = true;
            LabelGameName.Location = new Point(664, 82);
            LabelGameName.Name = "LabelGameName";
            LabelGameName.Size = new Size(0, 23);
            LabelGameName.TabIndex = 13;
            // 
            // GBBalance
            // 
            GBBalance.Controls.Add(LabelBalance);
            GBBalance.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GBBalance.ForeColor = SystemColors.ButtonHighlight;
            GBBalance.Location = new Point(946, 12);
            GBBalance.Name = "GBBalance";
            GBBalance.Size = new Size(135, 87);
            GBBalance.TabIndex = 15;
            GBBalance.TabStop = false;
            GBBalance.Text = "Баланс";
            // 
            // LabelBalance
            // 
            LabelBalance.AutoSize = true;
            LabelBalance.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelBalance.ForeColor = SystemColors.ButtonHighlight;
            LabelBalance.Location = new Point(31, 35);
            LabelBalance.Name = "LabelBalance";
            LabelBalance.Size = new Size(62, 23);
            LabelBalance.TabIndex = 16;
            LabelBalance.Text = "18,32$";
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 36);
            ClientSize = new Size(1095, 723);
            Controls.Add(GBBalance);
            Controls.Add(GBGamesForBuying);
            Controls.Add(groupBox1);
            Name = "ShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopForm";
            ((System.ComponentModel.ISupportInitialize)PBLargePhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBSmallPhotoTopLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBSmallPhotoTopRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBSmallPhotoBottomLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBSmallPhotoBottomRight).EndInit();
            groupBox1.ResumeLayout(false);
            GBGamesForBuying.ResumeLayout(false);
            GBGamesForBuying.PerformLayout();
            GBBalance.ResumeLayout(false);
            GBBalance.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BTNShop;
        private Button BTNLibrary;
        private Button BTNProfile;
        private Label label1;
        private PictureBox PBLargePhoto;
        private PictureBox PBSmallPhotoTopLeft;
        private PictureBox PBSmallPhotoTopRight;
        private PictureBox PBSmallPhotoBottomLeft;
        private PictureBox PBSmallPhotoBottomRight;
        private Label LabelNameOfGame;
        private Label LabelGenreOfGame;
        private GroupBox groupBox1;
        private GroupBox GBGamesForBuying;
        private Button BTNBuy;
        private Label LabelGameGenre;
        private Label LabelGameName;
        private Label LabelPrice;
        private GroupBox GBBalance;
        private Label LabelBalance;
        private ComboBox CBShopFormSearch;
    }
}
