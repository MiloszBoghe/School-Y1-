using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BalloonWithDelegate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Balloon balloon;
        private Ellipse ellipse;

        public MainWindow()
        {
            InitializeComponent();

            CreateEllipse();
            balloon = new Balloon();
            balloon.Display = new BalloonDisplayer(Redraw);
            balloon.Initialize(50, 50, 20);
        }

        private void Redraw(int x, int y, int diameter)
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Blue),
                StrokeThickness = 2
            };

            drawingCanvas.Children.Add(ellipse);
        }
        
        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveRight(20);
        }

        private void growButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.ChangeSize(20);
        }

        private void displayXButton_Click(object sender, RoutedEventArgs e)
        {
            xCoordTextBox.Text = Convert.ToString(balloon.XCoord);
        }

        private void changeXButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.XCoord = Convert.ToInt32(xCoordTextBox.Text);
        }
    }
}
