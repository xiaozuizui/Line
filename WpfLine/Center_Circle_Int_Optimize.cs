using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  
 * 
 * 使用Δd修正d
 * 
 */
namespace WpfLine
{
    public class Center_Circle_Int_Optimize:Circle
    {
        public Center_Circle_Int_Optimize(float _x, float _y, float R) : base(_x, _y, R)
        {
            int x = 0;
            int y = Convert.ToInt32(Rad);
            int d = 1 - Convert.ToInt32(Rad);

            int dt = 3;
            int db = -2 * Convert.ToInt32(Rad) + 5;

            while (y >= x)//绘制八分之一,右上圆
            {
                DrawCirclePoints(x, y);
                if (d < 0)//选择上光栅点,y不变
                {
                    d += dt;
                    dt += 2;
                    db += 2;
                }
                else//选择下光栅点
                {
                    d += db;
                    dt += 2;
                    db += 4;
                    y--;
                }
                x++;
            }

            Transfer();//坐标转换
        }
    }
}
