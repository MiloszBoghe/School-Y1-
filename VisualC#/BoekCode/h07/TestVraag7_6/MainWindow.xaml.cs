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

namespace TestVraag7_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            slider1.ValueChanged += CheckValues;
            slider2.ValueChanged += CheckValues;
            slider3.ValueChanged += CheckValues;
        }

        private void CheckValues(object sender,
                          RoutedPropertyChangedEventArgs<double> e)
        {
            double a = slider1.Value;
            double b = slider2.Value;
            double c = slider3.Value;
            double largest = a;

            if (b > largest)
            {
                largest = b;
            }

            if (c > largest)
            {
                largest = c;
            }

            messageLabel.Content = String.Format("largest value is {0:0.00}", largest);
        }
    }
}
