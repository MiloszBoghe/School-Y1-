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

namespace Opgave3._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Line l1 = new Line();
            l1.Stroke = new SolidColorBrush(Colors.Black);
            Line l2 = new Line();
            l2.Stroke = new SolidColorBrush(Colors.Yellow);
            Line l3 = new Line();
            l3.Stroke = new SolidColorBrush(Colors.Red);
            Line l4 = new Line();
            l4.Stroke = new SolidColorBrush(Colors.Purple);
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Fill = new SolidColorBrush(Colors.Black);
            Rectangle rectangle2 = new Rectangle();
            rectangle2.Fill = new SolidColorBrush(Colors.Yellow);
            Rectangle rectangle3 = new Rectangle();
            rectangle3.Fill = new SolidColorBrush(Colors.Red);
            Rectangle rectangle4 = new Rectangle();
            rectangle4.Fill = new SolidColorBrush(Colors.Purple);

            l1.X1 = 0;
            l2.X1 = 0;
            l3.X1 = 0;
            l4.X1 = 0;

            l1.X2 = 150;
            l2.X2 = 175;
            l3.X2 = 120;
            l4.X2 = 130;


            l1.Y1 = 50;
            l2.Y1 = 100;
            l3.Y1 = 150;
            l4.Y1 = 200;

            l1.Y2 = 50;
            l2.Y2 = 100;
            l3.Y2 = 150;
            l4.Y2 = 200;
            
            rectangle1.Margin = new Thickness(0,250,0,0);
            rectangle2.Margin = new Thickness(0,300,0,0);
            rectangle3.Margin = new Thickness(0,350,0,0);
            rectangle4.Margin = new Thickness(0,400,0,0);

            rectangle1.Width = l1.X2;
            rectangle2.Width = l2.X2;
            rectangle3.Width = l3.X2;
            rectangle4.Width = l4.X2;

            rectangle1.Height = 50; 
            rectangle2.Height = 50; 
            rectangle3.Height = 50;
            rectangle4.Height = 50;
            canvas1.Children.Add(l1);
            canvas1.Children.Add(l2);
            canvas1.Children.Add(l3);
            canvas1.Children.Add(l4);
            canvas1.Children.Add(rectangle1);
            canvas1.Children.Add(rectangle2);
            canvas1.Children.Add(rectangle3);
            canvas1.Children.Add(rectangle4);
        }
    }
}
