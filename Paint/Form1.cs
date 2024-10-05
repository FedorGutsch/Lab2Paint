

using System.Windows.Forms;

namespace Paint
{
    
    public partial class Form1 : Form
    {

        public Bitmap bitfield;
        Graphics gr;


        Color colorOfPen = Color.Gray;

       

        

        delegate void Ddraw(List<Point> points);
        public Form1()
        {
            InitializeComponent();
            bitfield = new Bitmap(1920, 1080);
            gr = Graphics.FromImage(bitfield);
            my_draw = Ellipse;
        }

        Ddraw my_draw;

        bool flag = false;

        void Ellipse(List<Point> points)
        {
            var p = points[0];
            //Graphics gr = CreateGraphics();
            gr.DrawEllipse(new Pen(colorOfPen), p.X, p.Y, 50, 50);

        }

        void Curve(List<Point> points)
        {
            var p = points[0];
            gr.DrawRectangle(new Pen(colorOfPen), p.X, p.Y, 1, 1);
        }

        void Eraser(List<Point> points)
        {
            var p = points[0];
            gr.DrawRectangle(Pens.White, p.X, p.Y, 1, 1);
        }

        void Line(List<Point> points)
        {
            var p1 = points[0];
            var p2 = points[1];
            gr.DrawLine(new Pen(colorOfPen), p1, p2);
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
        
        List<Point> points = new List<Point>();
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (my_draw == Curve || my_draw == Eraser)
            { flag = true; }

            if (my_draw != Line)
            {
                Bitmap copy = bitfield.Clone(new Rectangle(0, 0, bitfield.Width, bitfield.Height), bitfield.PixelFormat);

                List<Point> points = new List<Point>();
                points.Add(new Point(e.X, e.Y));

                my_draw(points);
                pictureBox1.Image = bitfield;
            }
            else
            {
                List<Point> points = new List<Point>();
                points.Add(new Point(e.X, e.Y));
                flag = true;
            }

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
                if (my_draw != Line)
                {
                    Bitmap copy = bitfield.Clone(new Rectangle(0, 0, bitfield.Width, bitfield.Height), bitfield.PixelFormat);

                    List<Point> points = new List<Point>();
                    points.Add(new Point(e.X, e.Y));

                    my_draw(points);
                    pictureBox1.Image = bitfield;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                Bitmap copy = bitfield.Clone(new Rectangle(0, 0, bitfield.Width, bitfield.Height), bitfield.PixelFormat);

                points.Add((new Point(e.X, e.Y)));

                my_draw(points);
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

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
