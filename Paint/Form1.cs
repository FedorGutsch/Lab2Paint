using System.Numerics;
using System.Text.Json;
using System.Windows.Forms;
using tools;
using System.Text.Json;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace Paint
{

    public partial class Form1 : Form
    {
        public Bitmap bitfield;
        Graphics gr;
        Color colorOfPen = Color.Gray;
        Workspace wp;
        delegate void Ddraw(List<Point> points, Color color);
        public Form1()
        {
            InitializeComponent();
            wp = new tools.Workspace();
            bitfield = new Bitmap(1920, 1080);
            gr = Graphics.FromImage(bitfield);
            my_draw = Ellipse;

        }
        Ddraw my_draw;
        bool flag = false;
        void Ellipse(List<Point> points, Color color)
        {
            var p = points[0];          
            gr.DrawEllipse(new Pen(color), p.X, p.Y, 50, 50);
            wp.AddFigure(new figure(1, color, points));
        }

        void Curve(List<Point> points, Color color)
        {
            var p = points[0];
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

        void Eraser(List<Point> points, Color color)
        {
            var p = points[0];
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

        void Line(List<Point> points, Color color)
        {
            var p1 = points[0];
            var p2 = points[1];
            gr.DrawLine(new Pen(color), p1, p2);
            wp.AddFigure(new figure(2, color, points));
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

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
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
                my_draw(points, colorOfPen);

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

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_draw = Ellipse;
        }

        private void кистьToolStripMenuItem_Click(object sender, EventArgs e)
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
                    my_draw(points, colorOfPen);
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
                    my_draw(points, colorOfPen);
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                points.Add((new Point(e.X, e.Y)));
                my_draw(points, colorOfPen);
                pictureBox1.Invalidate();
                points.Clear();
                flag = false;
            }
        }

        private void ластикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_draw = Eraser;
        }

        private void прямаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_draw = Line;
        }
        private void палитраToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorOfPen = colorDialog1.Color;
            }
        }

        private async void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "JSON files (*.json)|*.json";
            saveFileDialog1.Title = "Сохранить файл как";
            saveFileDialog1.DefaultExt = "json"; // Установка расширения по умолчанию
            saveFileDialog1.AddExtension = true; // Добавление расширения, если его нет
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {

                    await JsonSerializer.SerializeAsync<Stack<figure>>(fs, wp.figureList);
                    Console.WriteLine("Объект сериализован");
                }
            }
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitfield, 0, 0);
        }

        private async void импортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON files (*.json)|*.json";
            openFileDialog1.Title = "Открыть файл ";
            openFileDialog1.DefaultExt = "json"; // Установка расширения по умолчанию
            openFileDialog1.AddExtension = true; // Добавление расширения, если его нет

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    wp.figureList = (Stack<figure>)await JsonSerializer.DeserializeAsync<Stack<figure>>(fs);
                }
            }           
            drawFromStack(wp.figureList);            
        }


        // 0-rect 1-ellipse 2-line 3-curve 4-eraser
        public void drawFromStack(Stack<figure> st)
        {
            

            using (Graphics g = Graphics.FromImage(bitfield))
            {
                g.Clear(Color.White);
                pictureBox1.Invalidate();
            }

            List<figure> p = new List<figure>();
            
            while (st.Count > 0)
            {
                var f = st.Pop();
                p.Add(f);
            }

            foreach (figure f1 in p) 
            {
                switch (f1.Type)
                {
                    case 0:
                        {
                            
                            my_draw = Ellipse;
                            my_draw(f1.Points, f1.Color);
                            break;
                        }
                    case 1:
                        {
                            
                            my_draw = Ellipse;
                            my_draw(f1.Points, f1.Color);
                            break;
                        }
                    case 2:
                        {
                            
                            my_draw = Line;
                            my_draw(f1.Points, f1.Color);
                            break;
                        }
                    case 3:
                        {
                           
                            my_draw = Curve;
                            my_draw(f1.Points, f1.Color);
                            break;
                        }
                    case 4:
                        {
                           
                            my_draw = Eraser;
                            my_draw(f1.Points, Color.White);
                            break;
                        }
                }
            }
        }
    }
}
