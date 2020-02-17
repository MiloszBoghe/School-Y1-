using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Raindrops
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random randomNumber = new Random();
        private double x, y, size;
        private SolidColorBrush brush;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            gapLabel.Content = Convert.ToString(gapSlider.Value);
            brush = new SolidColorBrush(Colors.Red);
            timer.Interval = TimeSpan.FromMilliseconds(gapSlider.Value);
            timer.Tick += timer_Tick;
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            paperCanvas.Children.Clear();
        }
        private int count = 0;
        private SolidColorBrush[] brushArray = {
            new SolidColorBrush(Colors.Red), new SolidColorBrush(Colors.Black), new SolidColorBrush(Colors.Blue),new SolidColorBrush(Colors.Violet), new SolidColorBrush(Colors.Tomato)
        ,new SolidColorBrush(Colors.Thistle), new SolidColorBrush(Colors.Yellow), new SolidColorBrush(Colors.White)};
        Random random = new Random();
        private void timer_Tick(object sender, EventArgs e)
        {
            brush = brushArray[random.Next(brushArray.Length)];
            x = randomNumber.Next(0, Convert.ToInt32(window2.Width));
            y = randomNumber.Next(0, Convert.ToInt32(window2.Height));
            size = randomNumber.Next(1, 200);
            count++;
            //Ellipse ellipse = new Ellipse();
            //ellipse.Width = size;
            //ellipse.Height = size;
            //ellipse.Stroke = brush;
            //ellipse.Fill = brush;
            //ellipse.Margin = new Thickness(x, y, 0, 0);
            var ellipse = new Ellipse()
            {
                Width = size,
                Height = size,
                Stroke = brush,
                Fill = brush,
                Margin = new Thickness(x, y, 0, 0)
            };
            paperCanvas.Children.Add(ellipse);

            // set new interval for timer
            timer.Stop();
            int ms = randomNumber.Next(1, Convert.ToInt32(gapSlider.Value));
            timer.Interval = TimeSpan.FromMilliseconds(ms);
            timer.Start();
        }

        private void gapSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int timeGap = Convert.ToInt32(gapSlider.Value);
            gapLabel.Content = Convert.ToString(timeGap);
        }
    }
}
