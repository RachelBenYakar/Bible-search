namespace Tanach
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
            button1 = new Button();
            button2 = new Button();
            FindWord = new TextBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            listBox1 = new ListBox();
            count = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(1277, 86);
            button1.TabIndex = 0;
            button1.Text = "json-המרה ל";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1126, 129);
            button2.Name = "button2";
            button2.Size = new Size(163, 61);
            button2.TabIndex = 1;
            button2.Text = "חפש מילה";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FindWord
            // 
            FindWord.Location = new Point(917, 149);
            FindWord.Name = "FindWord";
            FindWord.Size = new Size(188, 23);
            FindWord.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(802, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(487, 382);
            dataGridView1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(542, 129);
            button3.Name = "button3";
            button3.Size = new Size(215, 61);
            button3.TabIndex = 4;
            button3.Text = "הצגת כל התנך";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(280, 208);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(477, 379);
            listBox1.TabIndex = 5;
            // 
            // count
            // 
            count.AutoSize = true;
            count.Location = new Point(1157, 598);
            count.Name = "count";
            count.Size = new Size(0, 15);
            count.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 611);
            Controls.Add(count);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(FindWord);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox FindWord;
        private DataGridView dataGridView1;
        private Button button3;
        private ListBox listBox1;
        private Label count;
    }
}
