using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Apartments
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            vertSlider.ValueChanged += Handle_ValueChanged;
            horizSlider.ValueChanged += Handle_ValueChanged;
        }

        void Handle_ValueChanged(object sender,
                            RoutedPropertyChangedEventArgs<double> e)
        {
            DrawFlats(Convert.ToInt32(vertSlider.Value),
                      Convert.ToInt32(horizSlider.Value));
        }

        private void DrawFlats(int floors, int flats)
        {
            apartmentsCanvas.Children.Clear();
            var brush = new SolidColorBrush(Colors.Black);

            double y = 5;
            for (int floor = 0; floor < floors; floor++)
            {
                double x = 5;
                for (int flat = 0; flat < flats; flat++)
                {
                    DrawRectangle(apartmentsCanvas, brush, x, y, 20, 10);
                    x = x + 25;
                }
                y = y + 20;
            }
        }

        private void DrawRectangle(Canvas paperCanvas, SolidColorBrush brush, double x, double y, double width, double height)
        {
            Rectangle rect = new Rectangle()
            {
                Width = width,
                Height = height,
                Margin = new Thickness(x, y, 0, 0),
                Stroke = brush
            };
            paperCanvas.Children.Add(rect);
        }
    }
}
