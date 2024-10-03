using System.Drawing;

namespace tools
{
    public class Workspace()
    {
        Stack<figure> figureList;

        public void AddFigure(figure figure)
        {
            figureList.Push(figure); 
        }
        public figure RemoveFigure(figure figure)
        {
            return figureList.Pop();
        }
    }


    public class figure
    {
        int type; 
        Color color;

        List<Point>? points;
        
        public figure(int type, Color color, List<Point> point)
        {
            Type = type;
            Color = color;
            Points = point;
        }

        public int Type
        {
            get { return type; }
            set { type  = value; }
        }
        public Color Color 
        {
            get { return color; }
            set { color = value; }
        }
        public List<Point> Points
        {
            get { return points; }
            set { points = value; }
        }

        
    }

}
