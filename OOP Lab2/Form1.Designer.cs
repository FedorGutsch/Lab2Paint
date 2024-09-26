namespace OOP_Lab2
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(4, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(933, 438);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(4, 7);
            button1.Name = "button1";
            button1.Size = new Size(59, 50);
            button1.TabIndex = 1;
            button1.Text = "crv";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(60, 7);
            button2.Name = "button2";
            button2.Size = new Size(59, 50);
            button2.TabIndex = 2;
            button2.Text = "str";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(116, 7);
            button3.Name = "button3";
            button3.Size = new Size(59, 50);
            button3.TabIndex = 3;
            button3.Text = "sqr";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Location = new Point(172, 7);
            button4.Name = "button4";
            button4.Size = new Size(59, 50);
            button4.TabIndex = 4;
            button4.Text = "rct";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Location = new Point(228, 7);
            button5.Name = "button5";
            button5.Size = new Size(59, 50);
            button5.TabIndex = 5;
            button5.Text = "elp";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Location = new Point(284, 7);
            button6.Name = "button6";
            button6.Size = new Size(59, 50);
            button6.TabIndex = 6;
            button6.Text = "clr";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Location = new Point(340, 7);
            button7.Name = "button7";
            button7.Size = new Size(59, 50);
            button7.TabIndex = 7;
            button7.Text = "bck";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.Location = new Point(396, 7);
            button8.Name = "button8";
            button8.Size = new Size(59, 50);
            button8.TabIndex = 8;
            button8.Text = "ers";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.Location = new Point(452, 7);
            button9.Name = "button9";
            button9.Size = new Size(59, 50);
            button9.TabIndex = 9;
            button9.Text = "ld";
            button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(937, 505);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Paint.Da";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private PictureBox pictureBox1;
    }
}
