using System.Collections.Generic;
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
        private List<Balloon> partyList = new List<Balloon>();
        private List<Ellipse> ellipseList = new List<Ellipse>();
        
        public MainWindow()
        {
            InitializeComponent();

            ellipseList.Add(CreateEllipse());
            ellipseList.Add(CreateEllipse());
            ellipseList.Add(CreateEllipse());

            partyList.Add(CreateBalloon());
            partyList.Add(CreateBalloon());
            partyList.Add(CreateBalloon());
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
            int balloonIndex = partyList.IndexOf((Balloon)sender);
            var ellipse = ellipseList[balloonIndex];
            ellipse.Margin = new Thickness(args.X, args.Y, 0, 0);
            ellipse.Width = args.Diameter;
            ellipse.Height = args.Diameter;
        }      
    }
}
