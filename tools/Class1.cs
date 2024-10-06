using System.Drawing;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json.Serialization;

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


       
        public figure(int type, int R, int G, int B, List<Point> points)
        {
            Type = type;
            r = R; g = G; b = B;
     
            Points = points;
        }

       public int R
        {
            get { return r; }
            set { r = value; }
        }
        public int G
        {
            get { return g; }
            set { g = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
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
