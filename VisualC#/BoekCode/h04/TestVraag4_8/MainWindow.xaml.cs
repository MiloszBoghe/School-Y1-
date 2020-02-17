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

namespace TestVraag4_8
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
            int m, n;
            string s;
            string v = "3";
            m = Convert.ToInt32(v + v + "4");
            n = Convert.ToInt32(v + v) + 4;
            s = Convert.ToString(Convert.ToInt32(v)
                + Convert.ToInt32(v)) + "4";

            MessageBox.Show(String.Format("{0}, {1}, {2}", m, n, s));
        }
    }
}
