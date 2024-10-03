using System.Drawing;

namespace tools
{
    public class ByHand
    {

    }

    public class Rectangle
    {
        int x;
        int y;
        int size;
        Color color;

        public Point Location 
        {
            get {return new Point(x, y);}
            set {
                    x = value.X;
                    y = value.Y;
                } 
        }


        public int X
        {
            get { return x; }          
        }
        public int Y
        {
            get { return y; }
        }


        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public Rectangle(int x, int y, int size, Color color) 
        { 
            this.x = x;
            this.y = y;
            this.Size = size;
            this.Color = color;

        }
        public Rectangle()
        {
            x = 0; y = 0;
            
            size = 0;
            color = Color.White;
        }
    }
}
