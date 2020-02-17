using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tom_and_Jerry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle tomRectangle;
        private Rectangle jerryRectangle;

        public MainWindow()
        {
            InitializeComponent();

            CreateRectangles();

            tomSlider.ValueChanged += SliderCompare;
            jerrySlider.ValueChanged += SliderCompare;
        }

        private void SliderCompare(object sender,
                           RoutedPropertyChangedEventArgs<double> e)
        {
            tomRectangle.Width = tomSlider.Value;
            jerryRectangle.Width = jerrySlider.Value;

            if (tomSlider.Value > jerrySlider.Value)
            {
                messageLabel.Content = "Tom is bigger";
            }
            else
            {
                messageLabel.Content = "Jerry is bigger";
            }
        }

        private void CreateRectangles()
        {
            tomRectangle = new Rectangle()
            {
                Fill = new SolidColorBrush(Colors.Blue),
                Margin = new Thickness(10, 10, 0, 0),
                Height = 30
            };

            jerryRectangle = new Rectangle()
            {
                Fill = new SolidColorBrush(Colors.Red),
                Margin = new Thickness(10, 90, 0, 0),
                Height = 30
            };
            
            paperCanvas.Children.Add(tomRectangle);
            paperCanvas.Children.Add(jerryRectangle);
        }
    }
}
