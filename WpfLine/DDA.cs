using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLine
{
    class DDA : Line
    {
        public DDA(int xs,int ys,int xe,int ye):base(xs,ys,xe,ye)
        {
          
            float k = (y_end - y_start) * 1.0f / (x_end - x_start);
            float y = y_start;
            for (int  x = x_start; x <= x_end; ++x)
            {
                Point temp = new Point(x,(int)Math.Round(y));
                points.Add(temp);
                y += k;
            }

        }
    }
}
