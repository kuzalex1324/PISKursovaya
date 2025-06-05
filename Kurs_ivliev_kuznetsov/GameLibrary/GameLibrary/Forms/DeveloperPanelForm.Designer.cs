namespace GameLibraryDA
{
    partial class DeveloperPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperPanelForm));
            pictureBox1 = new PictureBox();
            TBDevGameName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TBDevGameGenre = new TextBox();
            label3 = new Label();
            TBDevGamePrice = new TextBox();
            BTNSubmitRequest = new Button();
            BTNLoadFiles = new Button();
            LVApps = new ListView();
            label4 = new Label();
            dev_name = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 255);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // TBDevGameName
            // 
            TBDevGameName.Location = new Point(54, 35);
            TBDevGameName.Name = "TBDevGameName";
            TBDevGameName.Size = new Size(180, 30);
            TBDevGameName.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(79, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 27;
            label1.Text = "Название игры";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(116, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 29;
            label2.Text = "Жанр";
            // 
            // TBDevGameGenre
            // 
            TBDevGameGenre.Location = new Point(54, 100);
            TBDevGameGenre.Name = "TBDevGameGenre";
            TBDevGameGenre.Size = new Size(180, 30);
            TBDevGameGenre.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(116, 144);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 31;
            label3.Text = "Цена";
            // 
            // TBDevGamePrice
            // 
            TBDevGamePrice.Location = new Point(54, 170);
            TBDevGamePrice.Name = "TBDevGamePrice";
            TBDevGamePrice.Size = new Size(180, 30);
            TBDevGamePrice.TabIndex = 30;
            // 
            // BTNSubmitRequest
            // 
            BTNSubmitRequest.Location = new Point(30, 306);
            BTNSubmitRequest.Name = "BTNSubmitRequest";
            BTNSubmitRequest.Size = new Size(240, 34);
            BTNSubmitRequest.TabIndex = 32;
            BTNSubmitRequest.Text = "Подать заявку";
            BTNSubmitRequest.UseVisualStyleBackColor = true;
            BTNSubmitRequest.Click += BTNSubmitRequest_Click;
            // 
            // BTNLoadFiles
            // 
            BTNLoadFiles.Location = new Point(54, 233);
            BTNLoadFiles.Name = "BTNLoadFiles";
            BTNLoadFiles.Size = new Size(180, 34);
            BTNLoadFiles.TabIndex = 33;
            BTNLoadFiles.Text = "Загрузить файлы";
            BTNLoadFiles.UseVisualStyleBackColor = true;
            BTNLoadFiles.Click += BTNLoadFiles_Click;
            // 
            // LVApps
            // 
            LVApps.Location = new Point(549, 74);
            LVApps.Name = "LVApps";
            LVApps.Size = new Size(633, 255);
            LVApps.TabIndex = 34;
            LVApps.UseCompatibleStateImageBehavior = false;
            LVApps.View = View.List;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(881, 9);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 35;
            label4.Text = "Заявки";
            // 
            // dev_name
            // 
            dev_name.AutoSize = true;
            dev_name.ForeColor = SystemColors.ButtonHighlight;
            dev_name.Location = new Point(395, 35);
            dev_name.Name = "dev_name";
            dev_name.Size = new Size(42, 23);
            dev_name.TabIndex = 36;
            dev_name.Text = "Имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(567, 42);
            label5.Name = "label5";
            label5.Size = new Size(595, 23);
            label5.TabIndex = 37;
            label5.Text = "Статус             Дата создания              Имя Проверяющего             Причина";
            // 
            // DeveloperPanelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 36);
            ClientSize = new Size(1223, 365);
            Controls.Add(label5);
            Controls.Add(dev_name);
            Controls.Add(label4);
            Controls.Add(LVApps);
            Controls.Add(BTNLoadFiles);
            Controls.Add(BTNSubmitRequest);
            Controls.Add(label3);
            Controls.Add(TBDevGamePrice);
            Controls.Add(label2);
            Controls.Add(TBDevGameGenre);
            Controls.Add(label1);
            Controls.Add(TBDevGameName);
            Controls.Add(pictureBox1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DeveloperPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeveloperPanelForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TBDevGameName;
        private Label label1;
        private Label label2;
        private TextBox TBDevGameGenre;
        private Label label3;
        private TextBox TBDevGamePrice;
        private Button BTNSubmitRequest;
        private Button BTNLoadFiles;
        private ListView LVApps;
        private Label label4;
        private Label dev_name;
        private Label label5;
    }
}