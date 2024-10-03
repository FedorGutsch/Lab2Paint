

namespace Paint
{
    public partial class Form1 : Form
    {

        public Bitmap bitfield;
        Graphics gr;
        delegate void Ddraw(int x, int y);
        public Form1()
        {
            InitializeComponent();
            bitfield = new Bitmap(4096, 2160);
            gr = Graphics.FromImage(bitfield);
            my_draw = Ellipse;
        }

        Ddraw my_draw;

        bool flag = false;

        void Ellipse(int x, int y)
        {
            //Graphics gr = CreateGraphics();
            gr.DrawEllipse(Pens.Gray, x, y, 50, 50);

        }

        void Curve(int x, int y)
        {
            gr.DrawRectangle(Pens.Gray, x, y, 1, 1);
        }

        void Eraser(int x, int y)
        {
            gr.DrawRectangle(Pens.White, x, y, 1, 1);
        }

        void Line(int x, int y, int xs, int ys)
        {
            gr.DrawLine(Pens.Gray, x, y, xs, ys);
        }

        private Rectangle pictureBox1OriginalRectangle;
        private Rectangle originalFormSize;

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            pictureBox1OriginalRectangle = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)this.Width / (float)(originalFormSize.Width);
            float yRatio = (float)this.Height / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void ïðÿìîóãîëüíèêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (my_draw == Curve || my_draw == Eraser)
            { flag = true; }
            Bitmap copy = bitfield.Clone(new Rectangle(0, 0, bitfield.Width, bitfield.Height), bitfield.PixelFormat);
            my_draw(e.X, e.Y);
            pictureBox1.Image = bitfield;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(pictureBox1OriginalRectangle, pictureBox1);
        }

        private void êðóãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_draw = Ellipse;
        }

        private void êèñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_draw = Curve;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                Bitmap copy = bitfield.Clone(new Rectangle(0, 0, bitfield.Width, bitfield.Height), bitfield.PixelFormat);
                my_draw(e.X, e.Y);
                pictureBox1.Image = bitfield;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                Bitmap copy = bitfield.Clone(new Rectangle(0, 0, bitfield.Width, bitfield.Height), bitfield.PixelFormat);
                my_draw(e.X, e.Y);
                pictureBox1.Image = bitfield;
                flag = false;
            }
        }

        private void ëàñòèêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_draw = Eraser;
        }

        private void ïðÿìàÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
