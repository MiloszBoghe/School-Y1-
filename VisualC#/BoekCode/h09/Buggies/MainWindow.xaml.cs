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

namespace Buggies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //IndexOutOfRangeException
            int[] row = new int[10];
            for (int i = 0; i <= 10; i++)
            {
                row[i] = 0;
            }

            //int a, b, c;
            //b = 1;
            //c = Convert.ToInt32("0");
            //a = b / c;
        }
    }
}
