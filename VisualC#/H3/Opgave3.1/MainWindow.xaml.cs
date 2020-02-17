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

namespace Opgave3._1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Line l1 = new Line();
            Line l2 = new Line();
            Line l3 = new Line();

            l1.X1 = 100;
            l1.Y1 = 300;
            l1.X2 = 300;
            l1.Y2 = 300;

            l2.X1 = 100;
            l2.Y1 = 300;
            l2.X2 = 300;
            l2.Y2 = 50;

            l3.X1 = 300;
            l3.Y1 = 300;
            l3.X2 = 300;
            l3.Y2 = 50;

            l1.Stroke = new SolidColorBrush(Colors.Black);
            l2.Stroke = new SolidColorBrush(Colors.Red);
            l3.Stroke = new SolidColorBrush(Colors.Blue);
            rDrie.Children.Add(l1);
            rDrie.Children.Add(l2);
            rDrie.Children.Add(l3);
        }
    }
}
