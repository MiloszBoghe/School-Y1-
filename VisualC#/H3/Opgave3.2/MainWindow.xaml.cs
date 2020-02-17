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

namespace BoterKaasEieren
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

        private void Bord_Click(object sender, RoutedEventArgs e)
        {
            Line l1 = new Line();
            Line l2 = new Line();
            Line l3 = new Line();
            Line l4 = new Line();

            l1.X1 = 200;
            l1.Y1 = 0;
            l1.X2 = 200;
            l1.Y2 = 600;

            l2.X1 = 400;
            l2.Y1 = 0;
            l2.X2 = 400;
            l2.Y2 = 600;

            l3.X1 = 0;
            l3.Y1 = 200;
            l3.X2 = 600;
            l3.Y2 = 200;

            l4.X1 = 0;
            l4.Y1 = 400;
            l4.X2 = 600;
            l4.Y2 = 400;
            Rectangle rand = new Rectangle();
            rand.Width = 600;
            rand.Height = 600;
            rand.Stroke = new SolidColorBrush(Colors.Black);
            l1.Stroke = new SolidColorBrush(Colors.Black);
            l2.Stroke = new SolidColorBrush(Colors.Black);
            l3.Stroke = new SolidColorBrush(Colors.Black);
            l4.Stroke = new SolidColorBrush(Colors.Black);
            butter.Children.Add(rand);
            butter.Children.Add(l1);
            butter.Children.Add(l2);
            butter.Children.Add(l3);
            butter.Children.Add(l4);
        }
    }
}
