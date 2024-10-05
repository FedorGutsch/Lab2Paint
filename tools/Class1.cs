using System.Drawing;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;

namespace tools
{

    [Serializable]
    public class Workspace()
    {
        public Stack<figure> figureList = new Stack<figure>();

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

        string colorCode;
        
        List<Point>? points;
        


        public figure(int type, Color color, List<Point> points)
        {
            Type = type;
            colorCode = ColorTranslator.ToHtml(color); 
           
            Points = points;
        }

        public Color Color 
        { 
            get { return ColorTranslator.FromHtml(colorCode); }
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
