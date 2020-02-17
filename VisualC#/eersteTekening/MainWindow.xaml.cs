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

namespace eersteTekening
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

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            Rectangle upperRectangle = new Rectangle();
            upperRectangle.Width = 100;
            upperRectangle.Height = 50;
            upperRectangle.Margin = new Thickness(10,10,0,0);
            upperRectangle.Stroke = new SolidColorBrush(Colors.Black);
            upperRectangle.Fill = new SolidColorBrush(Colors.Blue);
            paperCanvas.Children.Add(upperRectangle);
            Rectangle lowerRectangle = new Rectangle();
            lowerRectangle.Width = 50;
            lowerRectangle.Height = 100;
            lowerRectangle.Margin = new Thickness(10, 100, 0, 0);
            lowerRectangle.Stroke = new SolidColorBrush(Colors.Red);
            lowerRectangle.Fill = new SolidColorBrush(Colors.Red);
            paperCanvas.Children.Add(lowerRectangle);
            Ellipse firstElipse = new Ellipse();
            firstElipse.Width = 50;
            firstElipse.Height = 50;
            firstElipse.Margin = new Thickness(10, 100, 0, 0);
            firstElipse.Stroke = new SolidColorBrush(Colors.Black);
            firstElipse.Fill = new SolidColorBrush(Colors.Blue);
            paperCanvas.Children.Add(firstElipse);
            Line lineRectangle = new Line();
            lineRectangle.X1 = 10;
            lineRectangle.Y1 = 10;
            lineRectangle.X2 = 110;
            lineRectangle.Y2 = 60;
            lineRectangle.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(lineRectangle);

            
        }

        private void SecondB_Click(object sender, RoutedEventArgs e)
        {
            Line dL1 = new Line();
            Line dL2 = new Line();
            Line dL3 = new Line();
            dL1.X1 = 10;
            dL1.X2 = 80;
            dL1.Y1 = 40;
            dL1.Y2 = 40;

            dL2.X1 = 10;
            dL2.X2 = 45;
            dL2.Y1 = 40;
            dL2.Y2 = 10;

            dL3.X1 = 80;
            dL3.X2 = 45;
            dL3.Y1 = 40;
            dL3.Y2 = 10;
            dL1.Stroke = new SolidColorBrush(Colors.Red);
            dL2.Stroke = new SolidColorBrush(Colors.Black);        
            dL3.Stroke = new SolidColorBrush(Colors.Blue);
            paperCanvas.Children.Add(dL1);
            paperCanvas.Children.Add(dL2);
            paperCanvas.Children.Add(dL3);
            BitmapImage demoBit = new BitmapImage();
            demoBit.BeginInit();
            demoBit.UriSource = new Uri(@"C:\Users\11800460\Desktop\Chicken.jpg",UriKind.RelativeOrAbsolute);
            demoBit.EndInit();
            Image rightImage = new Image();
            rightImage.Source = demoBit;
            rightImage.Margin = new Thickness(120, 10, 0, 0);
            rightImage.Width = 350;
            rightImage.Height = 350;
            paperCanvas.Children.Add(rightImage);

        }
    }
}
