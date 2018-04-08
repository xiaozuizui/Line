using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*变化量d是浮点数，运算较慢
 * 
 * 
 * D= d-0.25
 * d<0等价于D<-0.25
 * D为整数的情况下和D<0等价
 * 
 * 
*/
namespace WpfLine
{
    class Center_Circle_Int:Circle
    {
        Center_Circle_Int(float _x, float _y, float R):base(_x,_y,R) 
        {
            int x = 0;
            int y = Convert.ToInt32(Rad);
            int d = 1 - Convert.ToInt32(Rad);

            while (y > x)//绘制八分之一,右上圆
            {
                DrawCirclePoints(x, y);
                if (d < 0)//选择上光栅点,y不变
                {
                    d += 2 * x + 3;
                }
                else//选择下光栅点
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;
            }

            Transfer();//坐标转换
        }
    }
}
