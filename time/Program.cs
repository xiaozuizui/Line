﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLine;

namespace time
{
    class Program
    {
     


        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            


            double time_center_circle = 0;
            double time_centet_circle_int = 0;
            double time_center_circle_int_optimize = 0;
            double time_parameter_equation = 0;
            int numOfcircle = 100000;

            float x = 3.1f;
            float y = 3.2f;
            float rad = 12.2f;

            watch.Start();//开始计时
            for (int i=0;i<numOfcircle;i++)
            {
                Parameter_Equation_Circle cen = new Parameter_Equation_Circle(x, -y, rad);
            }
            watch.Stop();
            time_parameter_equation = watch.Elapsed.TotalSeconds;
            watch.Reset();

            watch.Start();
            for(int i=0;i<numOfcircle;i++)
            {
                Center_Circle cen = new Center_Circle(x, -y, rad);
            }
            watch.Stop();
            time_center_circle = watch.Elapsed.TotalSeconds;
            watch.Reset();

            watch.Start(); 
            for(int i=0;i<numOfcircle;i++)
            {
                Center_Circle_Int cen = new Center_Circle_Int(x, -y, rad);
            }
            watch.Stop();
            time_centet_circle_int = watch.Elapsed.TotalSeconds;
            watch.Reset();

            watch.Start();
            for(int i=0;i<numOfcircle;i++)
            {
                Center_Circle_Int_Optimize cen = new Center_Circle_Int_Optimize(x,-y,rad); 
            }
            watch.Stop();
            time_center_circle_int_optimize = watch.Elapsed.TotalSeconds;

            Console.WriteLine("参数方程："+time_parameter_equation);
            Console.WriteLine("中点圆："+time_center_circle);
            Console.WriteLine("中点圆整数："+time_centet_circle_int);
            Console.WriteLine("中点圆整数优化："+time_center_circle_int_optimize);

        }
    }
}
