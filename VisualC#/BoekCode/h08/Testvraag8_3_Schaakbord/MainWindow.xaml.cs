using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Testvraag8_3_Schaakbord
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
            chessCanvas.Children.Clear();

            var brush = new SolidColorBrush(Colors.Black);
            int x = 5;
            int y = 5;

            for (int counter = 0; counter < 9; counter++)
            {
                DrawLine(chessCanvas, brush, x, 5, x, 165);
                DrawLine(chessCanvas, brush, 5, y, 165, y);
                x += 20;
                y += 20;
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
