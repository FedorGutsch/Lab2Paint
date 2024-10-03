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
            panel1 = new Panel();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(10, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 301);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, инструментыToolStripMenuItem, палитраToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
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
            импортироватьToolStripMenuItem.Size = new Size(133, 22);
            импортироватьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // назадToolStripMenuItem
            // 
            назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            назадToolStripMenuItem.Size = new Size(133, 22);
            назадToolStripMenuItem.Text = "Назад";
            // 
            // впередToolStripMenuItem
            // 
            впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            впередToolStripMenuItem.Size = new Size(133, 22);
            впередToolStripMenuItem.Text = "Вперед";
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
            // 
            // прямаяToolStripMenuItem
            // 
            прямаяToolStripMenuItem.Name = "прямаяToolStripMenuItem";
            прямаяToolStripMenuItem.Size = new Size(163, 22);
            прямаяToolStripMenuItem.Text = "Прямая";
            // 
            // прямоугольникToolStripMenuItem
            // 
            прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            прямоугольникToolStripMenuItem.Size = new Size(163, 22);
            прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            // 
            // кругToolStripMenuItem
            // 
            кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            кругToolStripMenuItem.Size = new Size(163, 22);
            кругToolStripMenuItem.Text = "Круг";
            // 
            // ластикToolStripMenuItem
            // 
            ластикToolStripMenuItem.Name = "ластикToolStripMenuItem";
            ластикToolStripMenuItem.Size = new Size(163, 22);
            ластикToolStripMenuItem.Text = "Ластик";
            // 
            // палитраToolStripMenuItem
            // 
            палитраToolStripMenuItem.Name = "палитраToolStripMenuItem";
            палитраToolStripMenuItem.Size = new Size(66, 20);
            палитраToolStripMenuItem.Text = "Палитра";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
    }
}
