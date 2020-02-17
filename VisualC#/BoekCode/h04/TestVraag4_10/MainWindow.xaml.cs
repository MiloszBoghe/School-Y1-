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

namespace TestVraag4_10
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

        private void doitButton_Click(object sender, RoutedEventArgs e)
        {
            string result;

            int i, j, k;
            double a, b, c;
            int x = 3;
            double y = 2.7;

            i = (int)y;
            j = (int)(y + 0.6);
            k = Convert.ToInt32(x + 0.6);

            a = x;
            b = (int)y;
            c = (double)y;

            result = String.Format("a = {0:0.0}\r\nb = {1:0.0}\r\nc = {2:0.0}\r\ni = {3}\r\nj = {4}\r\nk = {5}",
                                   a, b, c, i, j, k);
            resultTextBox.Text = result;
        }
    }
}
