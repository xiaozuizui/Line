using System;
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
            int numOfcircle = 1000000;

            float x = 1.0f;
            float y = 1.0f;
            float rad = 9.2f;

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

            Console.WriteLine(time_parameter_equation);
            Console.WriteLine(time_center_circle);
            Console.WriteLine(time_centet_circle_int);
            Console.WriteLine(time_center_circle_int_optimize);

        }
    }
}
