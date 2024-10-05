

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using tools;

namespace Paint
{

    public partial class Form1 : Form
    {
        public Bitmap bitfield;
        Graphics gr;
        Color colorOfPen = Color.Gray;
        Workspace wp;
        delegate void Ddraw(List<Point> points);
        public Form1()
        {
            InitializeComponent();


            wp = new tools.Workspace();

            bitfield = new Bitmap(1920, 1080);
            gr = Graphics.FromImage(bitfield);

            my_draw = Ellipse;
            Color colorforfedya = Color.FromArgb();
        }

        Ddraw my_draw;

        bool flag = false;

        void Ellipse(List<Point> points)
        {
            var p = points[0];         
            gr.DrawEllipse(new Pen(colorOfPen), p.X, p.Y, 50, 50);
            wp.AddFigure(new figure(1, colorOfPen, points));
        }

        void Curve(List<Point> points)
        {
            var p = points[0];
            //gr.DrawRectangle(new Pen(colorOfPen), p.X, p.Y, 1, 1);
            //wp.AddFigure(new figure(3, colorOfPen, points));
            if (points.Count > 1)
            {
                using (Pen pen = new Pen(colorOfPen, 25))
                {
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    pen.LineJoin = LineJoin.Round;
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    gr.DrawLines(pen, points.ToArray());
                }
            }
        }

        void Eraser(List<Point> points)
        {
            var p = points[0];
            //gr.DrawRectangle(Pens.White, p.X, p.Y, 1, 1);
            //wp.AddFigure(new figure(4, Color.White, points));
            if (points.Count > 1)
            {
                using (Pen pen = new Pen(Color.White, 25))
                {
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    pen.LineJoin = LineJoin.Round;
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    gr.DrawLines(pen, points.ToArray());
                }
            }
        }

        void Line(List<Point> points)
        {
            var p1 = points[0];
            var p2 = points[1];

            gr.DrawLine(new Pen(colorOfPen), p1, p2);
            wp.AddFigure(new figure(2, colorOfPen, points));
        }

        void Rect(List<Point> points)
        {

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

        // 0-rect 1-ellipse 2-line 3-curve 4-eraser
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (my_draw == Curve || my_draw == Eraser)
            {
                flag = true;
            }

            if (my_draw != Line && my_draw != Curve && my_draw != Eraser)
            {
                List<Point> points = new List<Point>();
                points.Add(new Point(e.X, e.Y));
                my_draw(points);

                if (my_draw == Ellipse)
                {
                    figure figure1 = new figure(1, colorOfPen, points);
                }

                pictureBox1.Invalidate();
            }
            else
            {
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
                if (my_draw == Curve || my_draw == Eraser)
                {
                    points.Add(new Point(e.X, e.Y));
                    my_draw(points);
                    pictureBox1.Invalidate();
                    if (points.Count > 15)
                    {
                        points.Clear();
                    }
                }
                if (my_draw != Line && my_draw != Curve && my_draw != Eraser)
                {
                    List<Point> points = new List<Point>();
                    points.Add(new Point(e.X, e.Y));
                    my_draw(points);
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                points.Add((new Point(e.X, e.Y)));
                my_draw(points);
                pictureBox1.Invalidate();
                points.Clear();
                flag = false;
            }
        }

        private void ëàñòèêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_draw = Eraser;
        }

        private void ïðÿìàÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_draw = Line;
        }

        private void ïàëèòðàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ïàëèòðàToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorOfPen = colorDialog1.Color;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitfield, 0, 0);
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
