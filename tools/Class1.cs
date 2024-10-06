using System.Drawing;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;

namespace tools
{

    [Serializable]
    public class Workspace()
    {
        Stack<figure> figureList = new Stack<figure>();

        public void AddFigure(figure figure)
        {
            figureList.Push(figure); 
        }
        public figure RemoveFigure()
        {
            return figureList.Pop();
        }

        public Stack<figure> FigureList
        {
            get { return figureList; }
            set { figureList = value; }
        }
    }


    public class figure
    {
        int type;

        int r;
        int g;
        int b;
        
        List<Point>? points;
        


        public figure(int type, Color color, List<Point> points)
        {
            Type = type;
            r = color.R; g = color.G; b = color.B;
           
            Points = points;
        }

        public Color Color 
        { 
            get { return Color.FromArgb(r, g, b); }
        }

        public int Type
        {
            get { return type; }
            set { type  = value; }
        }
        
       public List<Point> Points
        {
            get { return points; }
            set { points = value; }
        }

        
    }

}
