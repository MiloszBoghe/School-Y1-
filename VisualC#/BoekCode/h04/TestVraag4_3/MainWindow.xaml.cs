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

namespace TestVraag4_3
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
            int a, b, c, d;
            d = -8;
            a = 1 * 2 + 3;
            b = 1 + 2 * 3;
            c = (1 + 2) * 3;
            c = a + b;
            d = -d;

            string bericht = String.Format("{0} {1} {2} {3}", a, b, c, d);
            MessageBox.Show(bericht);
        }
    }
}
