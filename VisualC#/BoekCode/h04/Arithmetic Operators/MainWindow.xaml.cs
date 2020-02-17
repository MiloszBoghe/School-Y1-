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

namespace Arithmetic_Operators
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

        private void resultsButton_Click(object sender, RoutedEventArgs e)
        {
            int i;
            int n = 3;
            double d;
            i = n + 3;      // i krijgt de waarde 6
            MessageBox.Show("i = " + i);
            i = n * 4;      // i krijgt de waarde 12
            MessageBox.Show("i = " + i);
            i = 7 + 2 * 4;  // i krijgt de waarde 15
            MessageBox.Show("i = " + i);
            n = n * (n + 2) * 4; // n krijgt de waarde 60
            MessageBox.Show("n = " + n);
            d = 3.5 / 2;  // d krijgt de waarde 1.75
            MessageBox.Show("d = " + d);
            n = 7 / 4;  //n krijgt de waarde 1
            MessageBox.Show("n = " + n);
        }
    }
}
