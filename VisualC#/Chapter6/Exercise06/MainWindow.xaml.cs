using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Exercise06
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private Rectangle minutesRectangle = new Rectangle
        {
            Margin = new Thickness(0, 130, 0, 0),
            Fill = new SolidColorBrush(Colors.Black),
            Width = 0,
            Height = 40,
            MaxWidth = 600
        };
        private Rectangle secondsRectangle = new Rectangle
        {
            Margin = new Thickness(0, 280, 0, 0),
            Fill = new SolidColorBrush(Colors.Black),
            Width = 0,
            Height = 40,
            MaxWidth = 600
        };

        public MainWindow()
        {
            InitializeComponent();
            timeCanvas.Children.Add(minutesRectangle);
            timeCanvas.Children.Add(secondsRectangle);
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.IsEnabled = true;
            timer.Tick += Timer_Tick;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsRectangle.Width+=10;
            if (secondsRectangle.Width == secondsRectangle.MaxWidth)
            {
                secondsRectangle.Width = 0;
                minutesRectangle.Width+=10;
            }
            if (minutesRectangle.Width == minutesRectangle.MaxWidth) minutesRectangle.Width = 0;


        }
    }
}
