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

namespace Divisions
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

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            // double divisions
            double d;
            //Output("d = " + d); // geeft compilerfout omdat d unassigned is
            d = 7.61 / 2.1;
            Output("d = " + d);
            d = 10.6 / 2;
            Output("d = " + d);

            // integer divisions
            int i;
            i = 10 / 5;
            Output("i = " + i);
            i = 13 / 5;
            Output("i = " + i);
            i = 33 / 44;
            Output("i = " + i);

            d = 14.9 % 3.9;
            Output("d = " + d);
        }

        private void Output(string message)
        {
            MessageBox.Show(message);
        }
    }
}
