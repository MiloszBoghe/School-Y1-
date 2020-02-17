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

namespace Triangle
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
            // draw a triangle
            // first line
            Line l1 = new Line();
            l1.X1 = 20; l1.Y1 = 80;
            l1.X2 = 70; l1.Y2 = 10;
            l1.Stroke = new SolidColorBrush(Colors.Black);
            // second line
            Line l2 = new Line();
            l2.X1 = 70; l2.Y1 = 10;
            l2.X2 = 120; l2.Y2 = 80;
            l2.Stroke = new SolidColorBrush(Colors.Black);
            // third line
            Line l3 = new Line();
            l3.X1 = 120; l3.Y1 = 80;
            l3.X2 = 20; l3.Y2 = 80;
            l3.Stroke = new SolidColorBrush(Colors.Black);
            // add to the canvas
            paperCanvas.Children.Add(l1);
            paperCanvas.Children.Add(l2);
            paperCanvas.Children.Add(l3);

            //Line rightLeg = new Line();
            //rightLeg.X1 = 20; rightLeg.Y1 = 80;
            //rightLeg.X2 = 70; rightLeg.Y2 = 10;
            //rightLeg.Stroke = new SolidColorBrush(Colors.Black);

            //Line leftLeg = new Line();
            //leftLeg.X1 = 70; leftLeg.Y1 = 10;
            //leftLeg.X2 = 120; leftLeg.Y2 = 80;
            //leftLeg.Stroke = new SolidColorBrush(Colors.Black);

            //Line triangleBase = new Line();
            //triangleBase.X1 = 120; triangleBase.Y1 = 80;
            //triangleBase.X2 = 20; triangleBase.Y2 = 80;
            //triangleBase.Stroke = new SolidColorBrush(Colors.Black);

            //paperCanvas.Children.Add(rightLeg);
            //paperCanvas.Children.Add(leftLeg);
            //paperCanvas.Children.Add(triangleBase);
        }
    }
}
