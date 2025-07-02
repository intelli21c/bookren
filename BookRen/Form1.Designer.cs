namespace BookRen
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
			textBox1 = new TextBox();
			listBox1 = new ListBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBox3 = new TextBox();
			label4 = new Label();
			richTextBox1 = new RichTextBox();
			label5 = new Label();
			textBox4 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			button7 = new Button();
			button8 = new Button();
			openFileDialog1 = new OpenFileDialog();
			comboBox1 = new ComboBox();
			checkBox1 = new CheckBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(454, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(494, 27);
			textBox1.TabIndex = 0;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.Location = new Point(12, 9);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(306, 284);
			listBox1.TabIndex = 5;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(324, 9);
			label1.Name = "label1";
			label1.Size = new Size(38, 20);
			label1.TabIndex = 6;
			label1.Text = "TItle";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(324, 42);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 8;
			label2.Text = "Category";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(324, 75);
			label3.Name = "label3";
			label3.Size = new Size(56, 20);
			label3.TabIndex = 10;
			label3.Text = "Author";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(454, 78);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(494, 27);
			textBox3.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(324, 108);
			label4.Name = "label4";
			label4.Size = new Size(86, 20);
			label4.TabIndex = 12;
			label4.Text = "Description";
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(454, 108);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(494, 148);
			richTextBox1.TabIndex = 13;
			richTextBox1.Text = "";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(324, 262);
			label5.Name = "label5";
			label5.Size = new Size(70, 20);
			label5.TabIndex = 15;
			label5.Text = "Filename";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(454, 262);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(494, 27);
			textBox4.TabIndex = 14;
			// 
			// button1
			// 
			button1.Location = new Point(854, 295);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 16;
			button1.Text = "Apply";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(125, 299);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 17;
			button2.Text = "Load";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(225, 299);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 18;
			button3.Text = "Write";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(754, 295);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 19;
			button4.Text = "Peek";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(654, 295);
			button5.Name = "button5";
			button5.Size = new Size(94, 29);
			button5.TabIndex = 20;
			button5.Text = "Reset";
			button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			button6.Location = new Point(554, 295);
			button6.Name = "button6";
			button6.Size = new Size(94, 29);
			button6.TabIndex = 21;
			button6.Text = "Delete";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// button7
			// 
			button7.Location = new Point(12, 299);
			button7.Name = "button7";
			button7.Size = new Size(107, 29);
			button7.TabIndex = 22;
			button7.Text = "Create(Scan)";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button8
			// 
			button8.Location = new Point(454, 295);
			button8.Name = "button8";
			button8.Size = new Size(94, 29);
			button8.TabIndex = 23;
			button8.Text = "Add";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(454, 45);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(494, 28);
			comboBox1.TabIndex = 24;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(325, 302);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(124, 24);
			checkBox1.TabIndex = 25;
			checkBox1.Text = "Specify folder";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(956, 335);
			Controls.Add(checkBox1);
			Controls.Add(comboBox1);
			Controls.Add(button8);
			Controls.Add(button7);
			Controls.Add(button6);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label5);
			Controls.Add(textBox4);
			Controls.Add(richTextBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(textBox3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(listBox1);
			Controls.Add(textBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Form1";
			Text = "Book Renamer";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private ListBox listBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox3;
		private Label label4;
		private RichTextBox richTextBox1;
		private Label label5;
		private TextBox textBox4;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Button button7;
		private Button button8;
		private OpenFileDialog openFileDialog1;
		private ComboBox comboBox1;
		private CheckBox checkBox1;
	}
}
