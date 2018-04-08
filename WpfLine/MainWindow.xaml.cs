using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLine
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
        TextBlock[,] textBlocks = new TextBlock[51, 51];

        public MainWindow()
        {
            InitializeComponent();

            int width=51, height=51;

            for (int i=0;i<height;i++)
            {
                MainG.RowDefinitions.Add(new RowDefinition());
                col.Children.Add(new Border() { BorderThickness = new Thickness(1, 0, 0, 0), BorderBrush = new SolidColorBrush(new Color { A = 255, R = 0, G = 0, B = 0 }), Height = 510, Width = 10 });
            }
            col.Children.Add(new Border() { BorderThickness = new Thickness(1, 0, 0, 0), BorderBrush = new SolidColorBrush(new Color { A = 255, R = 0, G = 0, B = 0 }), Height = 510, Width = 10 });

            for (int i = 0; i < width; i++)
            {
                MainG.ColumnDefinitions.Add(new ColumnDefinition());
               row.Children.Add(new Border() { BorderThickness = new Thickness(0, 1, 0, 0), BorderBrush = new SolidColorBrush(new Color { A = 255, R = 0, G = 0, B = 0 }), Height = 10, Width = 510 });
            }
             row.Children.Add(new Border() { BorderThickness = new Thickness(0, 1, 0, 0), BorderBrush = new SolidColorBrush(new Color { A = 255, R = 0, G = 0, B = 0 }), Height = 10, Width = 510 });

            for(int i=0;i<height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    textBlocks[i, j] = new TextBlock { Text = "", Width = 10, Height = 10 };
                    Grid.SetRow(textBlocks[i, j], i);
                    Grid.SetColumn(textBlocks[i, j], j);
                    MainG.Children.Add(textBlocks[i, j]);
                }
            }

          

        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            DDA dda = new DDA(0, 0, 20, 20);
            DrawLine drawLine = new DrawLine(ref dda.points,ref  textBlocks);
            drawLine.Draw();
        }

        private void Center_Circle_Click(object sender, RoutedEventArgs e)
        {
            Center_Circle cen = new Center_Circle(5, 0, 10);
            DrawLine drawLine = new DrawLine(ref cen.points, ref textBlocks);
            drawLine.Draw();
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 51; i++)
            {
                for (int j = 0; j < 51; j++)
                {
                    textBlocks[i, j].Background = null;
                }
            }
        }
    }
}
