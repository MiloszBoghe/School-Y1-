using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Remember
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool filled;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fillButton_Click(object sender, RoutedEventArgs e)
        {
            filled = true;
        }

        private void unFillButton_Click(object sender, RoutedEventArgs e)
        {
            filled = false;
        }

        //private void drawButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // remove any previous shapes
        //    paperCanvas.Children.Clear();

        //    SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
        //    Rectangle rectangle = new Rectangle()
        //    {
        //        Width = 100,
        //        Height = 100,
        //        Margin = new Thickness(10, 10, 0, 0),
        //        Stroke = brush
        //    };

        //    if (filled)
        //    {
        //        rectangle.Fill = brush;
        //    }
        //    else
        //    {
        //        rectangle.Fill = null;
        //    }
        //    paperCanvas.Children.Add(rectangle);
        //}

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            // remove any previous shapes
            paperCanvas.Children.Clear();

            SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
            Rectangle rectangle = new Rectangle()
            {
                Width = 100,
                Height = 100,
                Margin = new Thickness(10, 10, 0, 0),
                Stroke = brush,
                Fill = filled ? brush : null
            };
            
            paperCanvas.Children.Add(rectangle);
        }
    }
}
