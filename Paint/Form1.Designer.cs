namespace Paint
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
            colorDialog1 = new ColorDialog();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            импортироватьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            назадToolStripMenuItem = new ToolStripMenuItem();
            впередToolStripMenuItem = new ToolStripMenuItem();
            инструментыToolStripMenuItem = new ToolStripMenuItem();
            кистьToolStripMenuItem = new ToolStripMenuItem();
            прямаяToolStripMenuItem = new ToolStripMenuItem();
            прямоугольникToolStripMenuItem = new ToolStripMenuItem();
            кругToolStripMenuItem = new ToolStripMenuItem();
            ластикToolStripMenuItem = new ToolStripMenuItem();
            палитраToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, инструментыToolStripMenuItem, палитраToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(695, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { импортироватьToolStripMenuItem, сохранитьToolStripMenuItem, назадToolStripMenuItem, впередToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // импортироватьToolStripMenuItem
            // 
            импортироватьToolStripMenuItem.Name = "импортироватьToolStripMenuItem";
            импортироватьToolStripMenuItem.Size = new Size(180, 22);
            импортироватьToolStripMenuItem.Text = "Открыть";
            импортироватьToolStripMenuItem.Click += импортироватьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(180, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // назадToolStripMenuItem
            // 
            назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            назадToolStripMenuItem.Size = new Size(180, 22);
            назадToolStripMenuItem.Text = "Назад";
            назадToolStripMenuItem.Click += назадToolStripMenuItem_Click;
            // 
            // впередToolStripMenuItem
            // 
            впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            впередToolStripMenuItem.Size = new Size(180, 22);
            впередToolStripMenuItem.Text = "Вперед";
            впередToolStripMenuItem.Click += впередToolStripMenuItem_Click;
            // 
            // инструментыToolStripMenuItem
            // 
            инструментыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { кистьToolStripMenuItem, прямаяToolStripMenuItem, прямоугольникToolStripMenuItem, кругToolStripMenuItem, ластикToolStripMenuItem });
            инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            инструментыToolStripMenuItem.Size = new Size(95, 20);
            инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // кистьToolStripMenuItem
            // 
            кистьToolStripMenuItem.Name = "кистьToolStripMenuItem";
            кистьToolStripMenuItem.Size = new Size(163, 22);
            кистьToolStripMenuItem.Text = "Кисть";
            кистьToolStripMenuItem.Click += кистьToolStripMenuItem_Click;
            // 
            // прямаяToolStripMenuItem
            // 
            прямаяToolStripMenuItem.Name = "прямаяToolStripMenuItem";
            прямаяToolStripMenuItem.Size = new Size(163, 22);
            прямаяToolStripMenuItem.Text = "Прямая";
            прямаяToolStripMenuItem.Click += прямаяToolStripMenuItem_Click;
            // 
            // прямоугольникToolStripMenuItem
            // 
            прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            прямоугольникToolStripMenuItem.Size = new Size(163, 22);
            прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            прямоугольникToolStripMenuItem.Click += прямоугольникToolStripMenuItem_Click;
            // 
            // кругToolStripMenuItem
            // 
            кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            кругToolStripMenuItem.Size = new Size(163, 22);
            кругToolStripMenuItem.Text = "Круг";
            кругToolStripMenuItem.Click += кругToolStripMenuItem_Click;
            // 
            // ластикToolStripMenuItem
            // 
            ластикToolStripMenuItem.Name = "ластикToolStripMenuItem";
            ластикToolStripMenuItem.Size = new Size(163, 22);
            ластикToolStripMenuItem.Text = "Ластик";
            ластикToolStripMenuItem.Click += ластикToolStripMenuItem_Click;
            // 
            // палитраToolStripMenuItem
            // 
            палитраToolStripMenuItem.Name = "палитраToolStripMenuItem";
            палитраToolStripMenuItem.Size = new Size(66, 20);
            палитраToolStripMenuItem.Text = "Палитра";
            палитраToolStripMenuItem.Click += палитраToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(671, 291);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(695, 330);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem импортироватьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem назадToolStripMenuItem;
        private ToolStripMenuItem впередToolStripMenuItem;
        private ToolStripMenuItem инструментыToolStripMenuItem;
        private ToolStripMenuItem кистьToolStripMenuItem;
        private ToolStripMenuItem прямаяToolStripMenuItem;
        private ToolStripMenuItem прямоугольникToolStripMenuItem;
        private ToolStripMenuItem кругToolStripMenuItem;
        private ToolStripMenuItem ластикToolStripMenuItem;
        private ToolStripMenuItem палитраToolStripMenuItem;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
