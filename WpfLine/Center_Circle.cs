using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLine
{
    class Center_Circle:Circle
    {
        public Center_Circle(float _x, float _y, float R):base(_x,_y,R)
        {
            int x = 0;
            int y = Convert.ToInt32(Rad);
            float d = 1.25f - Rad;

            while (y > x)//绘制八分之一,右上圆
            {
                DrawCirclePoints(x, y);
                if (d < 0)//选择上光栅点,y不变
                {
                    d += 2.0f * x + 3.0f;
                }
                else//选择下光栅点
                {
                    d += 2.0f * (x - y) + 5.0f;
                    y--;
                }
                x++;
            }

            Transfer();//坐标转换
        }


    }
}
