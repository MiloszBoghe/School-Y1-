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

namespace TEe
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

        private void TEE_Click(object sender, RoutedEventArgs e)
        {
            Line l1 = new Line();
            Line l2 = new Line();
            l1.StrokeThickness = 4;
            l2.StrokeThickness = 4;
            l1.X1 = 200;
            l1.X2 = 200;
            l1.Y1 = 350;
            l1.Y2 = 180;

            l2.X1 = 100;
            l2.X2 = 300;
            l2.Y1 = 180;
            l2.Y2 = 180;

            l1.Stroke = new SolidColorBrush(Colors.Black);
            l2.Stroke = new SolidColorBrush(Colors.Black);

            canvas1.Children.Add(l1);
            canvas1.Children.Add(l2);
        }
    }
}
