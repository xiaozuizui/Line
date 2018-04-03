using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLine
{
    public class Line
    {
        public int x_start, y_start;
        public int x_end, y_end;
        public List<Point> points;

        public Line(int xs,int ys,int xe,int ye)
        {
            x_start = xs;y_start = ys; x_end = xe;y_end = ye;
            points = new List<Point>();
           
        }
    }
}
