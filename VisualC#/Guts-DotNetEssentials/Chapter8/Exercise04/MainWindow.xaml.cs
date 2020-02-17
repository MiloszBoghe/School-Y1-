using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int left;
        int top;
        int size;
        public MainWindow()
        {
            InitializeComponent();
            left = 5;
            top = 5;
            size = 40;
            DrawStairs();
        }

        Brush brush = new SolidColorBrush(Colors.Black);
        private void DrawRectangle(int size, int left, int top)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Stroke = brush;
            rectangle.Width = size;
            rectangle.Height = size;
            rectangle.Margin = new Thickness(left, top, 0, 0);
            stairCanvas.Children.Add(rectangle);
        }

        private void DrawStairs()
        {
            for (int i = 1; i < 7; i++)
            {
                DrawRectangle(size, left, top * i + size * (i - 1));
                for (int j = 2; j <= i; j++)
                {
                    DrawRectangle(size, left * j + size * (j - 1), top * i + size * (i - 1));
                }
            }
        }

    }
}
