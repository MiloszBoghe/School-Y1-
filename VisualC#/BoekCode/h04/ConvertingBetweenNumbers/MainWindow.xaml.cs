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

namespace ConvertingBetweenNumbers
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
            int i = 33;
            double d = 3.9;
            double d1;
            d1 = i;             // d1 wordt 33.0
            MessageBox.Show(Convert.ToString(d1));

            i = (int)d;         // i wordt 3
            MessageBox.Show(Convert.ToString(i));

            i = 33;
            d1 = Convert.ToDouble(i);     //d1 wordt 33.0
            MessageBox.Show(Convert.ToString(d1));

            i = Convert.ToInt32(d);       //i wordt 4
            MessageBox.Show(Convert.ToString(i));
        }
    }
}
