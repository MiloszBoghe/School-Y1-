using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TestVraag3_5
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
            Line topLeftToBottomRightLine = new Line();
            topLeftToBottomRightLine.X1 = 0; topLeftToBottomRightLine.Y1 = 0;
            topLeftToBottomRightLine.X2 = 100; topLeftToBottomRightLine.Y2 = 100;
            topLeftToBottomRightLine.Stroke = new SolidColorBrush(Colors.Black);

            Line bottomLeftToUpperRightLine = new Line();
            bottomLeftToUpperRightLine.X1 = 0; bottomLeftToUpperRightLine.Y1 = 100;
            bottomLeftToUpperRightLine.X2 = 100; bottomLeftToUpperRightLine.Y2 = 0;
            bottomLeftToUpperRightLine.Stroke = new SolidColorBrush(Colors.Black);

            paperCanvas.Children.Add(topLeftToBottomRightLine);
            paperCanvas.Children.Add(bottomLeftToUpperRightLine);
        }
    }
}
