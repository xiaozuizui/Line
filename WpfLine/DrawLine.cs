using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfLine
{
    public class DrawLine
    {
        private SolidColorBrush brush;
        private List<Point> Points;
        private TextBlock [,] textBlocks;

        public DrawLine(ref List<Point> points_,ref TextBlock [,] textBlocks_)
        {
            Points = points_;textBlocks = textBlocks_;
            Color color = new Color();
            color.A = 255;
            color.R = 0;
            color.G = 0;
            color.B = 0;
            brush = new SolidColorBrush(color);
        }

        public void Draw()
        {
            foreach(Point p in Points)
            {
                if (p.x > 50 || p.y > 50 || p.x < 0 || p.y < 0)
                    continue;
                else
                    textBlocks[p.y, p.x].Background = brush;
            }
        }
    }

    public class Point
    {
        public int x;
        public int y;
        
        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
    }

   //class Colors_
   // {
   //     static SolidColorBrush ReturnBrush(Color c)
   //     {
   //         return 
   //     }
   // }

    enum COLOR
    {
        RED,
        GREEN,
        BLACK,
    }
}
