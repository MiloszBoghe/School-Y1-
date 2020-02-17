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

namespace Huis
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Rectangle huis = new Rectangle();
            Rectangle deur = new Rectangle();
            Rectangle raam1 = new Rectangle();
            Rectangle raam2 = new Rectangle();
            Line l1 = new Line();
            Line l2 = new Line();


            huis.Width = 400;
            huis.Height = 300;
            huis.Margin = new Thickness(100, 200, 100, 0);

            l1.X1 = 100;
            l1.X2 = 300;
            l1.Y1 = 200;
            l1.Y2 = 0;

            l2.X1 = 300;
            l2.X2 = 500;
            l2.Y1 = 0;
            l2.Y2 = 200;

            raam1.Width = 80;
            raam1.Height = 80;

            raam2.Width = 80;
            raam2.Height = 80;

            raam1.Margin = new Thickness(150,250,0,0);
            raam2.Margin = new Thickness(375,250,0,0);

            deur.Margin = new Thickness(260, 370,0,0);
            deur.Width = 80;
            deur.Height = 130;

            huis.Stroke = new SolidColorBrush(Colors.Black);
            deur.Stroke = new SolidColorBrush(Colors.Black);
            raam1.Stroke = new SolidColorBrush(Colors.Green);
            raam2.Stroke = new SolidColorBrush(Colors.Green);
            l1.Stroke = new SolidColorBrush(Colors.Red);
            l2.Stroke = new SolidColorBrush(Colors.Red);

            canvas1.Children.Add(huis);
            canvas1.Children.Add(deur);
            canvas1.Children.Add(raam1);
            canvas1.Children.Add(raam2);
            canvas1.Children.Add(l1);
            canvas1.Children.Add(l2);

        }
    }
}
