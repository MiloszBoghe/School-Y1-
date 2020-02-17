using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Bouncing_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse ellipse;
        private DispatcherTimer timer;
        int xChange;
        int yChange;
        double x;
        double y;
        double diameter;

        public MainWindow()
        {
            InitializeComponent();
            ellipse = new Ellipse();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan();
            timer.Tick += Timer_Tick;
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            ballCanvas.Children.Remove(ellipse);
            MoveBall();
        }
        private void ballCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            xChange = 10;
            yChange = 4;
            x = 10;
            y = 10;
            diameter = 15;
            timer.Start();
        }

        private void MoveBall()
        {
            if ((x <= 0) || (x+diameter >= ballCanvas.Width))
            {
                xChange = -xChange;
            }
            if ((y <= 0) || (y+diameter >= ballCanvas.Height))
            {
                yChange = -yChange;
            }

            x = x + xChange;
            y = y + yChange;
            DrawBall();
        }

        private void DrawBall()
        {
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ballCanvas.Children.Add(ellipse);
        }
    }
}
