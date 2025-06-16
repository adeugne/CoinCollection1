namespace CoinCollection
{
    partial class FormSelectCoin
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
            dataGridViewCoinsPreview = new DataGridView();
            button1 = new Button();
            buttonCancelSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoinsPreview).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCoinsPreview
            // 
            dataGridViewCoinsPreview.AllowUserToAddRows = false;
            dataGridViewCoinsPreview.AllowUserToDeleteRows = false;
            dataGridViewCoinsPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoinsPreview.Location = new Point(10, 9);
            dataGridViewCoinsPreview.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCoinsPreview.MultiSelect = false;
            dataGridViewCoinsPreview.Name = "dataGridViewCoinsPreview";
            dataGridViewCoinsPreview.RowHeadersWidth = 51;
            dataGridViewCoinsPreview.Size = new Size(768, 381);
            dataGridViewCoinsPreview.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(522, 403);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 35);
            button1.TabIndex = 2;
            button1.Text = "Обрано";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAdd_Click;
            // 
            // buttonCancelSelect
            // 
            buttonCancelSelect.Location = new Point(657, 404);
            buttonCancelSelect.Margin = new Padding(3, 2, 3, 2);
            buttonCancelSelect.Name = "buttonCancelSelect";
            buttonCancelSelect.Size = new Size(122, 33);
            buttonCancelSelect.TabIndex = 3;
            buttonCancelSelect.Text = "Відміна";
            buttonCancelSelect.UseVisualStyleBackColor = true;
            buttonCancelSelect.Click += buttonCancelSelect_Click;
            // 
            // FormSelectCoin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 442);
            Controls.Add(buttonCancelSelect);
            Controls.Add(button1);
            Controls.Add(dataGridViewCoinsPreview);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSelectCoin";
            Text = "Оберіть монету для додавання";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoinsPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCoinsPreview;
        private Button button1;
        private Button buttonCancelSelect;
    }
}