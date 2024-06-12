namespace WinFormsApp2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 16;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.Controls.Add(comboBox1, 11, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 11, 1);
            tableLayoutPanel1.Controls.Add(button1, 7, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 16;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.Size = new Size(663, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox1, 5);
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Text files (*.txt)|*.txt", "Image files (*.png;*.jpg)|*.png;*.jpg", "All files (*.*)|*.*" });
            comboBox1.Location = new Point(454, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            tableLayoutPanel1.SetColumnSpan(listBox1, 5);
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(454, 31);
            listBox1.Name = "listBox1";
            tableLayoutPanel1.SetRowSpan(listBox1, 15);
            listBox1.Size = new Size(206, 416);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(290, 31);
            button1.Name = "button1";
            tableLayoutPanel1.SetRowSpan(button1, 2);
            button1.Size = new Size(76, 50);
            button1.TabIndex = 2;
            button1.Text = "Выбрать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button button1;
    }
}
