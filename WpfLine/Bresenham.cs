using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLine
{
    class Bresenham:Line
    {
        public Bresenham(int xs, int ys, int xe, int ye) : base(xs, ys, xe, ye)
        {
            int dx = Math.Abs(x_start - x_end);
            int dy = Math.Abs(y_start - y_end);
            int y = y_start;
            int e = -2 * dx;
            for (int x = x_start; x <= x_end; ++x)
            {
                 = true;
                e += 2 * dy;
                if (e > 0) ++y;
                if (e >= dx) e -= 2 * dx;
            }

        }
    }
}
