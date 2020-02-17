using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Boxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            countSlider.ValueChanged += countSlider_ValueChanged;
        }

        private void countSlider_ValueChanged(object sender,
                                 RoutedPropertyChangedEventArgs<double> e)
        {
            double x = 5;
            int numberOfBoxes = Convert.ToInt32(countSlider.Value);
            var brush = new SolidColorBrush(Colors.Black);
            
            boxesCanvas.Children.Clear();
            
            for (int counter = 1; counter <= numberOfBoxes; counter++)
            {
                DrawRectangle(boxesCanvas, brush, x, 15, 15, 15);
                x = x + 25;
            }
        }

        private void DrawRectangle(Canvas paperCanvas, SolidColorBrush brush,
                                   double x, double y, int width, int height)
        {
            Rectangle rectangle = new Rectangle()
            {
                Width = width,
                Height = height,
                Margin= new Thickness(x, y, 0, 0),
                Stroke = brush
            };
            paperCanvas.Children.Add(rectangle);
        }
    }
}
