namespace WinForm01
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 167);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "PUTZ RALUCA 2";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 200);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "E DIGGO MAIS";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 134);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 1;
            label3.Text = "PUTZ RALUCA";
            label3.Click += label1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1", "A", "@", ".", "ATICH" });
            checkedListBox1.Location = new Point(638, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 220);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(278, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 200);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 5;
            label4.Text = "o que eu diggo?";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 266);
            button2.Name = "button2";
            button2.Size = new Size(200, 23);
            button2.TabIndex = 0;
            button2.Text = "SAI RALUCA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(418, 134);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Resumir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 392);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Resumo da treta";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button2;
        private Button button1;
    }
}