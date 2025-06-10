
namespace CoinCollection
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            buttonUserSave = new Button();
            buttonUserChange = new Button();
            buttonUserRemove = new Button();
            buttonUserShow = new Button();
            panel3 = new Panel();
            textBoxUserCountry = new TextBox();
            label4 = new Label();
            buttonUserAdd = new Button();
            panel2 = new Panel();
            textBoxUserPhone = new TextBox();
            label3 = new Label();
            textBoxUserEmail = new TextBox();
            label2 = new Label();
            dataGridViewUser = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            UserEmail = new DataGridViewTextBoxColumn();
            UserPhone = new DataGridViewTextBoxColumn();
            UserCountry = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            textBoxUserName = new TextBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            buttonCoinsSave = new Button();
            buttonCoinRemove = new Button();
            buttonCoinChange = new Button();
            buttonCoinView = new Button();
            panel9 = new Panel();
            textBoxCoinMintage = new TextBox();
            label10 = new Label();
            panel8 = new Panel();
            textBoxCoinMetal = new TextBox();
            label9 = new Label();
            panel7 = new Panel();
            textBoxCoinPrice = new TextBox();
            label8 = new Label();
            panel6 = new Panel();
            textBoxCoinYear = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            textBoxCoinCountry = new TextBox();
            label6 = new Label();
            pictureBoxCoin = new PictureBox();
            panel4 = new Panel();
            textBoxCoinName = new TextBox();
            label5 = new Label();
            button1 = new Button();
            dataGridViewCoins = new DataGridView();
            ColumnCoinName = new DataGridViewTextBoxColumn();
            ColumnCoinPath = new DataGridViewTextBoxColumn();
            ColumnCoinCountry = new DataGridViewTextBoxColumn();
            ColumnCoinYear = new DataGridViewTextBoxColumn();
            ColumnCoinPrice = new DataGridViewTextBoxColumn();
            ColumnCoinMetal = new DataGridViewTextBoxColumn();
            ColumnMintage = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoins).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-4, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(931, 521);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(923, 488);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Головна сторінка";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonUserSave);
            tabPage2.Controls.Add(buttonUserChange);
            tabPage2.Controls.Add(buttonUserRemove);
            tabPage2.Controls.Add(buttonUserShow);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(buttonUserAdd);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(dataGridViewUser);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 488);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Користувачі";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonUserSave
            // 
            buttonUserSave.Location = new Point(475, 440);
            buttonUserSave.Name = "buttonUserSave";
            buttonUserSave.Size = new Size(175, 29);
            buttonUserSave.TabIndex = 8;
            buttonUserSave.Text = "Зберегти в файл";
            buttonUserSave.UseVisualStyleBackColor = true;
            buttonUserSave.Click += button1_Click;
            // 
            // buttonUserChange
            // 
            buttonUserChange.Location = new Point(353, 440);
            buttonUserChange.Name = "buttonUserChange";
            buttonUserChange.Size = new Size(94, 29);
            buttonUserChange.TabIndex = 7;
            buttonUserChange.Text = "Змінити";
            buttonUserChange.UseVisualStyleBackColor = true;
            // 
            // buttonUserRemove
            // 
            buttonUserRemove.Location = new Point(231, 440);
            buttonUserRemove.Name = "buttonUserRemove";
            buttonUserRemove.Size = new Size(94, 29);
            buttonUserRemove.TabIndex = 6;
            buttonUserRemove.Text = "Видалити";
            buttonUserRemove.UseVisualStyleBackColor = true;
            buttonUserRemove.Click += buttonUserRemove_Click;
            // 
            // buttonUserShow
            // 
            buttonUserShow.Location = new Point(118, 440);
            buttonUserShow.Name = "buttonUserShow";
            buttonUserShow.Size = new Size(94, 29);
            buttonUserShow.TabIndex = 5;
            buttonUserShow.Text = "Показати";
            buttonUserShow.UseVisualStyleBackColor = true;
            buttonUserShow.Click += buttonUserShow_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxUserCountry);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(702, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 98);
            panel3.TabIndex = 3;
            // 
            // textBoxUserCountry
            // 
            textBoxUserCountry.Location = new Point(16, 53);
            textBoxUserCountry.Name = "textBoxUserCountry";
            textBoxUserCountry.Size = new Size(158, 27);
            textBoxUserCountry.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 17);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 1;
            label4.Text = "Країна";
            // 
            // buttonUserAdd
            // 
            buttonUserAdd.Location = new Point(400, 141);
            buttonUserAdd.Name = "buttonUserAdd";
            buttonUserAdd.Size = new Size(94, 29);
            buttonUserAdd.TabIndex = 4;
            buttonUserAdd.Text = "Додати";
            buttonUserAdd.UseVisualStyleBackColor = true;
            buttonUserAdd.Click += buttonUserAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxUserPhone);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxUserEmail);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(263, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 98);
            panel2.TabIndex = 3;
            // 
            // textBoxUserPhone
            // 
            textBoxUserPhone.Location = new Point(212, 53);
            textBoxUserPhone.Name = "textBoxUserPhone";
            textBoxUserPhone.Size = new Size(158, 27);
            textBoxUserPhone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 17);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Телефон";
            // 
            // textBoxUserEmail
            // 
            textBoxUserEmail.Location = new Point(16, 53);
            textBoxUserEmail.Name = "textBoxUserEmail";
            textBoxUserEmail.Size = new Size(158, 27);
            textBoxUserEmail.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 17);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { UserName, UserEmail, UserPhone, UserCountry });
            dataGridViewUser.Location = new Point(3, 185);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.ReadOnly = true;
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(917, 234);
            dataGridViewUser.TabIndex = 3;
            // 
            // UserName
            // 
            UserName.HeaderText = "П.І.Б";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 125;
            // 
            // UserEmail
            // 
            UserEmail.HeaderText = "Email";
            UserEmail.MinimumWidth = 6;
            UserEmail.Name = "UserEmail";
            UserEmail.ReadOnly = true;
            UserEmail.Width = 125;
            // 
            // UserPhone
            // 
            UserPhone.HeaderText = "Телефон";
            UserPhone.MinimumWidth = 6;
            UserPhone.Name = "UserPhone";
            UserPhone.ReadOnly = true;
            UserPhone.Width = 125;
            // 
            // UserCountry
            // 
            UserCountry.HeaderText = "Країна";
            UserCountry.MinimumWidth = 6;
            UserCountry.Name = "UserCountry";
            UserCountry.ReadOnly = true;
            UserCountry.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 98);
            panel1.TabIndex = 2;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(16, 53);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(158, 27);
            textBoxUserName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "П.І.Б.";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonCoinsSave);
            tabPage3.Controls.Add(buttonCoinRemove);
            tabPage3.Controls.Add(buttonCoinChange);
            tabPage3.Controls.Add(buttonCoinView);
            tabPage3.Controls.Add(panel9);
            tabPage3.Controls.Add(panel8);
            tabPage3.Controls.Add(panel7);
            tabPage3.Controls.Add(panel6);
            tabPage3.Controls.Add(panel5);
            tabPage3.Controls.Add(pictureBoxCoin);
            tabPage3.Controls.Add(panel4);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(dataGridViewCoins);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(923, 488);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Монети";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonCoinsSave
            // 
            buttonCoinsSave.Location = new Point(691, 451);
            buttonCoinsSave.Name = "buttonCoinsSave";
            buttonCoinsSave.Size = new Size(199, 29);
            buttonCoinsSave.TabIndex = 12;
            buttonCoinsSave.Text = "Зберегти";
            buttonCoinsSave.UseVisualStyleBackColor = true;
            buttonCoinsSave.Click += buttonCoinsSave_Click;
            // 
            // buttonCoinRemove
            // 
            buttonCoinRemove.Location = new Point(443, 451);
            buttonCoinRemove.Name = "buttonCoinRemove";
            buttonCoinRemove.Size = new Size(199, 29);
            buttonCoinRemove.TabIndex = 11;
            buttonCoinRemove.Text = "Видалити";
            buttonCoinRemove.UseVisualStyleBackColor = true;
            buttonCoinRemove.Click += buttonCoinRemove_Click;
            // 
            // buttonCoinChange
            // 
            buttonCoinChange.Location = new Point(226, 451);
            buttonCoinChange.Name = "buttonCoinChange";
            buttonCoinChange.Size = new Size(199, 29);
            buttonCoinChange.TabIndex = 10;
            buttonCoinChange.Text = "Змінити";
            buttonCoinChange.UseVisualStyleBackColor = true;
            // 
            // buttonCoinView
            // 
            buttonCoinView.Location = new Point(12, 451);
            buttonCoinView.Name = "buttonCoinView";
            buttonCoinView.Size = new Size(199, 29);
            buttonCoinView.TabIndex = 9;
            buttonCoinView.Text = "Перегляд монети";
            buttonCoinView.UseVisualStyleBackColor = true;
            buttonCoinView.Click += buttonCoinView_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(textBoxCoinMintage);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(408, 127);
            panel9.Name = "panel9";
            panel9.Size = new Size(192, 98);
            panel9.TabIndex = 8;
            // 
            // textBoxCoinMintage
            // 
            textBoxCoinMintage.Location = new Point(16, 53);
            textBoxCoinMintage.Name = "textBoxCoinMintage";
            textBoxCoinMintage.Size = new Size(158, 27);
            textBoxCoinMintage.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 17);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 1;
            label10.Text = "Тираж";
            // 
            // panel8
            // 
            panel8.Controls.Add(textBoxCoinMetal);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(210, 127);
            panel8.Name = "panel8";
            panel8.Size = new Size(192, 98);
            panel8.TabIndex = 7;
            // 
            // textBoxCoinMetal
            // 
            textBoxCoinMetal.Location = new Point(16, 53);
            textBoxCoinMetal.Name = "textBoxCoinMetal";
            textBoxCoinMetal.Size = new Size(158, 27);
            textBoxCoinMetal.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 17);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 1;
            label9.Text = "Метал";
            // 
            // panel7
            // 
            panel7.Controls.Add(textBoxCoinPrice);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(12, 127);
            panel7.Name = "panel7";
            panel7.Size = new Size(192, 98);
            panel7.TabIndex = 6;
            // 
            // textBoxCoinPrice
            // 
            textBoxCoinPrice.Location = new Point(16, 53);
            textBoxCoinPrice.Name = "textBoxCoinPrice";
            textBoxCoinPrice.Size = new Size(158, 27);
            textBoxCoinPrice.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 17);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 1;
            label8.Text = "Ціна";
            label8.Click += label8_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBoxCoinYear);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(408, 23);
            panel6.Name = "panel6";
            panel6.Size = new Size(192, 98);
            panel6.TabIndex = 5;
            // 
            // textBoxCoinYear
            // 
            textBoxCoinYear.Location = new Point(16, 53);
            textBoxCoinYear.Name = "textBoxCoinYear";
            textBoxCoinYear.Size = new Size(158, 27);
            textBoxCoinYear.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 17);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 1;
            label7.Text = "Рік";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBoxCoinCountry);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(210, 23);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 98);
            panel5.TabIndex = 4;
            // 
            // textBoxCoinCountry
            // 
            textBoxCoinCountry.Location = new Point(16, 53);
            textBoxCoinCountry.Name = "textBoxCoinCountry";
            textBoxCoinCountry.Size = new Size(158, 27);
            textBoxCoinCountry.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 17);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 1;
            label6.Text = "Країна";
            // 
            // pictureBoxCoin
            // 
            pictureBoxCoin.BackColor = Color.IndianRed;
            pictureBoxCoin.Location = new Point(701, 23);
            pictureBoxCoin.Name = "pictureBoxCoin";
            pictureBoxCoin.Size = new Size(165, 156);
            pictureBoxCoin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCoin.TabIndex = 4;
            pictureBoxCoin.TabStop = false;
            pictureBoxCoin.Click += pictureBoxCoin_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxCoinName);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(12, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 98);
            panel4.TabIndex = 3;
            // 
            // textBoxCoinName
            // 
            textBoxCoinName.Location = new Point(16, 53);
            textBoxCoinName.Name = "textBoxCoinName";
            textBoxCoinName.Size = new Size(158, 27);
            textBoxCoinName.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 17);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 1;
            label5.Text = "Назва монетки";
            // 
            // button1
            // 
            button1.Location = new Point(701, 196);
            button1.Name = "button1";
            button1.Size = new Size(165, 29);
            button1.TabIndex = 1;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridViewCoins
            // 
            dataGridViewCoins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoins.Columns.AddRange(new DataGridViewColumn[] { ColumnCoinName, ColumnCoinPath, ColumnCoinCountry, ColumnCoinYear, ColumnCoinPrice, ColumnCoinMetal, ColumnMintage });
            dataGridViewCoins.Location = new Point(12, 263);
            dataGridViewCoins.Name = "dataGridViewCoins";
            dataGridViewCoins.RowHeadersWidth = 51;
            dataGridViewCoins.Size = new Size(878, 175);
            dataGridViewCoins.TabIndex = 0;
            // 
            // ColumnCoinName
            // 
            ColumnCoinName.HeaderText = "Ім'я монети";
            ColumnCoinName.MinimumWidth = 6;
            ColumnCoinName.Name = "ColumnCoinName";
            ColumnCoinName.Width = 125;
            // 
            // ColumnCoinPath
            // 
            ColumnCoinPath.HeaderText = "Шлях";
            ColumnCoinPath.MinimumWidth = 6;
            ColumnCoinPath.Name = "ColumnCoinPath";
            ColumnCoinPath.Width = 125;
            // 
            // ColumnCoinCountry
            // 
            ColumnCoinCountry.HeaderText = "Країна походження";
            ColumnCoinCountry.MinimumWidth = 6;
            ColumnCoinCountry.Name = "ColumnCoinCountry";
            ColumnCoinCountry.Width = 125;
            // 
            // ColumnCoinYear
            // 
            ColumnCoinYear.HeaderText = "Рік походження";
            ColumnCoinYear.MinimumWidth = 6;
            ColumnCoinYear.Name = "ColumnCoinYear";
            ColumnCoinYear.Width = 125;
            // 
            // ColumnCoinPrice
            // 
            ColumnCoinPrice.HeaderText = "Ціна";
            ColumnCoinPrice.MinimumWidth = 6;
            ColumnCoinPrice.Name = "ColumnCoinPrice";
            ColumnCoinPrice.Width = 125;
            // 
            // ColumnCoinMetal
            // 
            ColumnCoinMetal.HeaderText = "Метал";
            ColumnCoinMetal.MinimumWidth = 6;
            ColumnCoinMetal.Name = "ColumnCoinMetal";
            ColumnCoinMetal.Width = 125;
            // 
            // ColumnMintage
            // 
            ColumnMintage.HeaderText = "Тираж";
            ColumnMintage.MinimumWidth = 6;
            ColumnMintage.Name = "ColumnMintage";
            ColumnMintage.Width = 125;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(926, 522);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoins).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem1;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private Label label1;
        private TextBox textBoxUserName;
        private Panel panel2;
        private TextBox textBoxUserPhone;
        private Label label3;
        private TextBox textBoxUserEmail;
        private Label label2;
        private DataGridView dataGridViewUser;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBoxUserCountry;
        private Label label4;
        private Button buttonUserAdd;
        private Button buttonUserChange;
        private Button buttonUserRemove;
        private Button buttonUserShow;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserEmail;
        private DataGridViewTextBoxColumn UserPhone;
        private DataGridViewTextBoxColumn UserCountry;
        private Button buttonUserSave;
        private Panel panel4;
        private TextBox textBoxCoinName;
        private Label label5;
        private Button button1;
        private DataGridView dataGridViewCoins;
        private PictureBox pictureBoxCoin;
        private Panel panel7;
        private TextBox textBoxCoinPrice;
        private Label label8;
        private Panel panel6;
        private TextBox textBoxCoinYear;
        private Label label7;
        private Panel panel5;
        private TextBox textBoxCoinCountry;
        private Label label6;
        private OpenFileDialog openFileDialog1;
        private Panel panel8;
        private TextBox textBoxCoinMetal;
        private Label label9;
        private Panel panel9;
        private TextBox textBoxCoinMintage;
        private Label label10;
        private DataGridViewTextBoxColumn ColumnCoinName;
        private DataGridViewTextBoxColumn ColumnCoinPath;
        private DataGridViewTextBoxColumn ColumnCoinCountry;
        private DataGridViewTextBoxColumn ColumnCoinYear;
        private DataGridViewTextBoxColumn ColumnCoinPrice;
        private DataGridViewTextBoxColumn ColumnCoinMetal;
        private DataGridViewTextBoxColumn ColumnMintage;
        private Button buttonCoinRemove;
        private Button buttonCoinChange;
        private Button buttonCoinView;
        private Button buttonCoinsSave;
    }
}
