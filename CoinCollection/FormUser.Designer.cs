namespace CoinCollection
{
    partial class FormUser
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
            label1 = new Label();
            panel1 = new Panel();
            labelUserName = new Label();
            buttonUserClose = new Button();
            panel2 = new Panel();
            labelUserEmail = new Label();
            label3 = new Label();
            panel3 = new Panel();
            labelUserPhone = new Label();
            label5 = new Label();
            panel4 = new Panel();
            labelUserCountry = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 115);
            panel1.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserName.Location = new Point(18, 52);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(669, 41);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Користувач Користувач Користувач";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonUserClose
            // 
            buttonUserClose.Font = new Font("Segoe UI", 14F);
            buttonUserClose.Location = new Point(614, 628);
            buttonUserClose.Name = "buttonUserClose";
            buttonUserClose.Size = new Size(130, 44);
            buttonUserClose.TabIndex = 3;
            buttonUserClose.Text = "Закрити";
            buttonUserClose.UseVisualStyleBackColor = true;
            buttonUserClose.Click += buttonUserClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelUserEmail);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(38, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 115);
            panel2.TabIndex = 3;
            // 
            // labelUserEmail
            // 
            labelUserEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUserEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserEmail.Location = new Point(18, 54);
            labelUserEmail.Name = "labelUserEmail";
            labelUserEmail.Size = new Size(646, 44);
            labelUserEmail.TabIndex = 1;
            labelUserEmail.Text = "Електронна пошта";
            labelUserEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 16);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 0;
            label3.Text = "Електронна поштв";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelUserPhone);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(38, 299);
            panel3.Name = "panel3";
            panel3.Size = new Size(706, 124);
            panel3.TabIndex = 4;
            // 
            // labelUserPhone
            // 
            labelUserPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUserPhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserPhone.Location = new Point(18, 50);
            labelUserPhone.Name = "labelUserPhone";
            labelUserPhone.Size = new Size(646, 49);
            labelUserPhone.TabIndex = 1;
            labelUserPhone.Text = "Телефон Телефон";
            labelUserPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 16);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 0;
            label5.Text = "Телефон";
            // 
            // panel4
            // 
            panel4.Controls.Add(labelUserCountry);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(38, 469);
            panel4.Name = "panel4";
            panel4.Size = new Size(706, 136);
            panel4.TabIndex = 5;
            // 
            // labelUserCountry
            // 
            labelUserCountry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUserCountry.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserCountry.Location = new Point(18, 52);
            labelUserCountry.Name = "labelUserCountry";
            labelUserCountry.Size = new Size(669, 66);
            labelUserCountry.TabIndex = 1;
            labelUserCountry.Text = "Країна Країна";
            labelUserCountry.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 16);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 0;
            label7.Text = "Країна";
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 693);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonUserClose);
            Controls.Add(panel1);
            Name = "FormUser";
            Text = "FormUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        public Label labelUserName;
        private Button buttonUserClose;
        private Panel panel2;
        public Label labelUserEmail;
        private Label label3;
        private Panel panel3;
        public Label labelUserPhone;
        private Label label5;
        private Panel panel4;
        public Label labelUserCountry;
        private Label label7;
    }
}