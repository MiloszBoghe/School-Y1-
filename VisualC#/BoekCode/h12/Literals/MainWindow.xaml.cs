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

namespace Literals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PlayWithLiterals();
        }

        private static void PlayWithLiterals()
        {
            double small = 12.34;
            double smaller = 0.000_1;

            double large = 10_000;

            int larger = 12_300_000;

            small = 1E-4;
            large = 1.23E7;

            small = 0.000_1;
            large = 12_300_000;

            MessageBox.Show($"{small} and {smaller} and {large} and {larger}");
        }
    }
}
