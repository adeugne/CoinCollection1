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
            dataGridViewOwn = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOwn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 20);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 69);
            panel1.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelUserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserName.Location = new Point(92, 12);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(592, 41);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Користувач Користувач Користувач";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonUserClose
            // 
            buttonUserClose.Font = new Font("Segoe UI", 14F);
            buttonUserClose.Location = new Point(527, 197);
            buttonUserClose.Margin = new Padding(3, 2, 3, 2);
            buttonUserClose.Name = "buttonUserClose";
            buttonUserClose.Size = new Size(114, 33);
            buttonUserClose.TabIndex = 3;
            buttonUserClose.Text = "Закрити";
            buttonUserClose.UseVisualStyleBackColor = true;
            buttonUserClose.Click += buttonUserClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelUserEmail);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(33, 100);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 61);
            panel2.TabIndex = 3;
            // 
            // labelUserEmail
            // 
            labelUserEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserEmail.Location = new Point(13, 22);
            labelUserEmail.Name = "labelUserEmail";
            labelUserEmail.Size = new Size(318, 33);
            labelUserEmail.TabIndex = 1;
            labelUserEmail.Text = "Електронна пошта";
            labelUserEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 2);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 0;
            label3.Text = "Електронна поштв";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelUserPhone);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(408, 100);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 61);
            panel3.TabIndex = 4;
            // 
            // labelUserPhone
            // 
            labelUserPhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserPhone.Location = new Point(14, 19);
            labelUserPhone.Name = "labelUserPhone";
            labelUserPhone.Size = new Size(317, 37);
            labelUserPhone.TabIndex = 1;
            labelUserPhone.Text = "Телефон Телефон";
            labelUserPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 2);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 0;
            label5.Text = "Телефон";
            // 
            // panel4
            // 
            panel4.Controls.Add(labelUserCountry);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(33, 180);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(346, 61);
            panel4.TabIndex = 5;
            // 
            // labelUserCountry
            // 
            labelUserCountry.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserCountry.Location = new Point(16, 17);
            labelUserCountry.Name = "labelUserCountry";
            labelUserCountry.Size = new Size(315, 37);
            labelUserCountry.TabIndex = 1;
            labelUserCountry.Text = "Країна Країна";
            labelUserCountry.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 2);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 0;
            label7.Text = "Країна";
            // 
            // dataGridViewOwn
            // 
            dataGridViewOwn.AllowUserToAddRows = false;
            dataGridViewOwn.AllowUserToDeleteRows = false;
            dataGridViewOwn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOwn.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridViewOwn.Location = new Point(33, 266);
            dataGridViewOwn.Margin = new Padding(3, 2, 3, 2);
            dataGridViewOwn.MultiSelect = false;
            dataGridViewOwn.Name = "dataGridViewOwn";
            dataGridViewOwn.RowHeadersWidth = 51;
            dataGridViewOwn.Size = new Size(768, 190);
            dataGridViewOwn.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ім'я монети";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Розташування картинки";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Країна походження";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Рік походження";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Ціна";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Метал";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Тираж";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 476);
            Controls.Add(dataGridViewOwn);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonUserClose);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormUser";
            Text = "Користувач";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOwn).EndInit();
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
        private DataGridView dataGridViewOwn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}