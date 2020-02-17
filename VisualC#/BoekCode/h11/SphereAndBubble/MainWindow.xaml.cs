using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SphereAndBubble
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Sphere sphere;
        private Bubble bubble;
        private Ball ball;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sphereButton_Click(object sender, RoutedEventArgs e)
        {
            if (sphere == null)
            {
                sphere = new Sphere();
                sphere.CreateEllipse(paperCanvas);
            }
            else
            {
                sphere.X = 0;
            }
        }

        private void bubbleButton_Click(object sender, RoutedEventArgs e)
        {
            if (bubble == null)
            {
                bubble = new Bubble();
                bubble.CreateEllipse(paperCanvas);
                bubble.Size = 5;
            }
            else
            {
                bubble.MoveVertical(5);
            }
        }

        private void ballButton_Click(object sender, RoutedEventArgs e)
        {
            if (ball == null)
            {
                ball = new Ball();
                ball.CreateEllipse(paperCanvas);
            }
            else
            {
                ball.MoveRight(5);
            }
        }
    }
}
