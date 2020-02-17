using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace ConvertToString
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
            string s1, s2;
            int num = 44;
            double d = 1.234;
            s1 = Convert.ToString(num);
            s2 = Convert.ToString(d);

            MessageBox.Show(s1);
            MessageBox.Show(s2);

            // Dit werkt niet op een Nederlands/Belgisch systeem
            //s1 = "12.3";
            //s2 = "567";
            //d = Convert.ToDouble(s1);
            //num = Convert.ToInt32(s2);
            //MessageBox.Show("" + d + " " + num);

            // We geven aan dat het een Amerikaanse getalvoorstelling betreft
            // moet wel bovenaan using System.Globalization
            s1 = "12.3";
            CultureInfo cult = new CultureInfo("en-US");
            d = Convert.ToDouble(s1, cult.NumberFormat);
            MessageBox.Show("" + d);

            //Testvraag 4.8
            int m, n;
            string s;
            string v = "3";
            m = Convert.ToInt32(v + v + "4");
            n = Convert.ToInt32(v + v) + 4;
            s = Convert.ToString(Convert.ToInt32(v)
                + Convert.ToInt32(v)) + "4";
            MessageBox.Show("m = " + m + "\n" +
                            "n = " + n + "\n" +
                            "s = " + s);
        }
    }
}
