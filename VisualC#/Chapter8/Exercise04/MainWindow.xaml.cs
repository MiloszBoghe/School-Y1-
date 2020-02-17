using System.Windows;
using System.Windows.Media;
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
        private void DrawRectangle(int left, int top)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Stroke = brush;
            rectangle.Width = size;
            rectangle.Height = size;
            rectangle.Margin = new Thickness(left, top, 0, 0);
            rectangleCanvas.Children.Add(rectangle);
        }

        private void DrawStairs()
        {
            for (int i = 1; i < 7; i++)
            {
                DrawRectangle(left, top * i + size * (i - 1));
                for (int j = 2; j <= i; j++)
                {
                    DrawRectangle(left * j + size * (j - 1), top * i + size * (i - 1));
                }
            }
        }

    }
}
