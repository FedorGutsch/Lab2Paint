namespace OOP_Lab2
{
    public partial class Form1 : Form
    {
        public Bitmap bitfield;
        Graphics gr;
        Stack<Bitmap> stack;
        public Form1()
        {
            InitializeComponent();
            stack = new Stack<Bitmap>();
            bitfield = new Bitmap(4096, 2160);
            gr = Graphics.FromImage(bitfield);
        }

        private Rectangle button1OriginalRectangle;
        private Rectangle button2OriginalRectangle;
        private Rectangle button3OriginalRectangle;
        private Rectangle button4OriginalRectangle;
        private Rectangle button5OriginalRectangle;
        private Rectangle button6OriginalRectangle;
        private Rectangle button7OriginalRectangle;
        private Rectangle button8OriginalRectangle;
        private Rectangle button9OriginalRectangle;
        private Rectangle pictureBox1OriginalRectangle;
        private Rectangle originalFormSize;

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            button1OriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button2OriginalRectangle = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            button3OriginalRectangle = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            button4OriginalRectangle = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            button5OriginalRectangle = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            button6OriginalRectangle = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            button7OriginalRectangle = new Rectangle(button7.Location.X, button7.Location.Y, button7.Width, button7.Height);
            button8OriginalRectangle = new Rectangle(button8.Location.X, button8.Location.Y, button8.Width, button8.Height);
            button9OriginalRectangle = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(button1OriginalRectangle, button1);
            resizeControl(pictureBox1OriginalRectangle, pictureBox1);
            resizeControl(button2OriginalRectangle, button2);
            resizeControl(button3OriginalRectangle, button3);
            resizeControl(button4OriginalRectangle, button4);
            resizeControl(button5OriginalRectangle, button5);
            resizeControl(button6OriginalRectangle, button6);
            resizeControl(button7OriginalRectangle, button7);
            resizeControl(button8OriginalRectangle, button8);
            resizeControl(button9OriginalRectangle, button9);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap copy = bitfield.Clone(new Rectangle(0, 0, bitfield.Width, bitfield.Height), bitfield.PixelFormat);
            stack.Push(copy);
            gr.DrawRectangle(Pens.Gray, e.X, e.Y, 50, 50);
            pictureBox1.Image = bitfield;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                bitfield = stack.Pop();
                pictureBox1.Image = bitfield;
                gr = Graphics.FromImage(bitfield);
            }

        }
    }
}
