using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLine
{
    public class Circle
    {
        public float Rad;
        public int c_x, c_y;
        public List<Point> points;

        public Circle(float _x,float _y,float R)
        {
            c_x = Convert.ToInt16( Math.Round(_x+0.5f));
            c_y = Convert.ToInt16(Math.Round(_y + 0.5f));
            Rad = R;
            points = new List<Point>();
           
        }

        public void DrawCirclePoints(int x,int y) //此处为圆坐标系
        {
            points.Add(new Point(x, y));
            points.Add(new Point(-x, y));
            points.Add(new Point(-x, -y));
            points.Add(new Point(x, -y));
            points.Add(new Point(y, x));
            points.Add(new Point(-y, x));
            points.Add(new Point(-y,-x));
            points.Add(new Point(y, -x));
        }

        public void Transfer()
        {
            for(int i=0;i<points.Count;i++)
            {
                points[i].x += 25+c_x;
                points[i].y  = -points[i].y+ 25+c_y;
            }
        }
    }
}
