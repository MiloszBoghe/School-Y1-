using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Testvraag8_2_Tralies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            barsCanvas.Children.Clear();

            var brush = new SolidColorBrush(Colors.Blue);
            int numberOfBars = 5;
            int x = 10;
            for (int counter = 0; counter < numberOfBars; counter++)
            {
                DrawLine(barsCanvas, brush, x, 10, x, 100);
                x = x + 15;
            }
        }

        private void DrawLine(Canvas paperCanvas, SolidColorBrush brush,
                              int x1, int y1, int x2, int y2)
        {
            Line line = new Line()
            {
                X1 = x1, Y1 = y1,
                X2 = x2, Y2 = y2,
                Stroke = brush,
                StrokeThickness = 3
            };
            paperCanvas.Children.Add(line);
        }
    }
}
