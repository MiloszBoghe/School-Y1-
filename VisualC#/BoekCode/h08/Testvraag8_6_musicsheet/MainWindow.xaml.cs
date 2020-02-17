using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Testvraag8_6_musicsheet
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

            int y = 5;
            var brush = new SolidColorBrush(Colors.Black);
            for (int staves = 0; staves < 8; staves++)
            {
                for (int lines = 0; lines < 5; lines++)
                {
                    DrawLine(barsCanvas, brush, 10, y, 180, y);
                    y = y + 4;
                }
                y = y + 10;
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
                StrokeThickness = 1
            };
            paperCanvas.Children.Add(line);
        }
    }
}
