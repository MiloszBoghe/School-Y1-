using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Balloons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Balloon[] partyList = new Balloon[10];
        private Ellipse[] ellipseList = new Ellipse[10];

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                partyList[i] = CreateBalloon();
                ellipseList[i] = CreateEllipse();
            }
        }

        private Balloon CreateBalloon()
        {
            var balloon = new Balloon();
            balloon.BalloonChanged += UpdateEllipse;

            return balloon;
        }

        private Ellipse CreateEllipse()
        {
            var ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Blue),
                StrokeThickness = 2
            };

            balloonCanvas.Children.Add(ellipse);
            return ellipse;
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            partyList[0].Initialize(10, 10, 50);
            partyList[1].Initialize(50, 50, 100);
            partyList[2].Initialize(100, 100, 200);
        }

        private void UpdateEllipse(object sender, BalloonChangedEventArgs args)
        {
            int balloonIndex = IndexOf((Balloon)sender, partyList);
            var ellipse = ellipseList[balloonIndex];
            ellipse.Margin = new Thickness(args.X, args.Y, 0, 0);
            ellipse.Width = args.Diameter;
            ellipse.Height = args.Diameter;
        }

        private int IndexOf(Balloon balloon, Balloon[] balloons)
        {
            int index = -1;
            int i = 0;
            while ((index == -1) && (i < balloons.Length))
            {
                if (balloons[i] == balloon)
                {
                    index = i;
                }
                i++;
            }
            return index;
        }
    }
}
