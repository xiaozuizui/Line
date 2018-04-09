using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLine
{
    public class Parameter_Equation_Circle:Circle
    {
        public Parameter_Equation_Circle(float _x, float _y, float R) : base(_x, _y, R)
        {
            int x = Convert.ToInt32(Math.Round(R + 0.5));
            int y = 0;

            double thta = 0;
            while (y <= x)//绘制八分之一,右上圆
            {
                DrawCirclePoints(x, y);
                x = Convert.ToInt32( R* Math.Cos(thta));
                y = Convert.ToInt32(R * Math.Sin(thta));
                thta += 1.0/72.0*Math.PI;
             }

            Transfer();

        }
    }
}
