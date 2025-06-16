namespace CoinCollection
{
    partial class FormCoin
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
            panel1 = new Panel();
            labelCoinName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            labelCoinPrice = new Label();
            label3 = new Label();
            panel3 = new Panel();
            labelCoinYear = new Label();
            label5 = new Label();
            panel4 = new Panel();
            labelCoinMintage = new Label();
            label7 = new Label();
            panel5 = new Panel();
            labelCoinDescription = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCoinName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 62);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // labelCoinName
            // 
            labelCoinName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCoinName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoinName.Location = new Point(95, 12);
            labelCoinName.Name = "labelCoinName";
            labelCoinName.Size = new Size(486, 37);
            labelCoinName.TabIndex = 1;
            labelCoinName.Text = "Назва монети";
            labelCoinName.TextAlign = ContentAlignment.MiddleCenter;
            labelCoinName.Click += labelCoinName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelCoinPrice);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(19, 109);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 129);
            panel2.TabIndex = 4;
            // 
            // labelCoinPrice
            // 
            labelCoinPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCoinPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoinPrice.Location = new Point(17, 58);
            labelCoinPrice.Name = "labelCoinPrice";
            labelCoinPrice.Size = new Size(125, 39);
            labelCoinPrice.TabIndex = 1;
            labelCoinPrice.Text = "Ціна";
            labelCoinPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 26);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "Ціна";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelCoinYear);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(241, 109);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 129);
            panel3.TabIndex = 5;
            // 
            // labelCoinYear
            // 
            labelCoinYear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCoinYear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoinYear.Location = new Point(17, 58);
            labelCoinYear.Name = "labelCoinYear";
            labelCoinYear.Size = new Size(126, 50);
            labelCoinYear.TabIndex = 1;
            labelCoinYear.Text = "Рік";
            labelCoinYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 26);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 0;
            label5.Text = "Рік";
            // 
            // panel4
            // 
            panel4.Controls.Add(labelCoinMintage);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(460, 109);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(160, 129);
            panel4.TabIndex = 5;
            // 
            // labelCoinMintage
            // 
            labelCoinMintage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCoinMintage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoinMintage.Location = new Point(17, 58);
            labelCoinMintage.Name = "labelCoinMintage";
            labelCoinMintage.Size = new Size(124, 50);
            labelCoinMintage.TabIndex = 1;
            labelCoinMintage.Text = "Тираж";
            labelCoinMintage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 26);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 0;
            label7.Text = "Тираж";
            // 
            // panel5
            // 
            panel5.Controls.Add(labelCoinDescription);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(19, 265);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(601, 62);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // labelCoinDescription
            // 
            labelCoinDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCoinDescription.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCoinDescription.Location = new Point(95, 12);
            labelCoinDescription.Name = "labelCoinDescription";
            labelCoinDescription.Size = new Size(486, 40);
            labelCoinDescription.TabIndex = 1;
            labelCoinDescription.Text = "Опис монети";
            labelCoinDescription.TextAlign = ContentAlignment.MiddleCenter;
            labelCoinDescription.Click += labelCoinDescription_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 26);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 0;
            label8.Text = "Опис";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(640, 23);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(642, 265);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(225, 62);
            button1.TabIndex = 7;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormCoin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 356);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCoin";
            Text = "Перегляд монети";
            Load += FormCoin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label labelCoinName;
        private Label label1;
        private Panel panel2;
        public Label labelCoinPrice;
        private Label label3;
        private Panel panel3;
        public Label labelCoinYear;
        private Label label5;
        private Panel panel4;
        public Label labelCoinMintage;
        private Label label7;
        private Panel panel5;
        public Label labelCoinDescription;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button1;
    }
}