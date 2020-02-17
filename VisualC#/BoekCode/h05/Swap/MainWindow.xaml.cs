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

namespace Swap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            int a = 6;
            int b = 8;
            int c = 20;
            int d = 30;

            Swap(ref c, ref d);
            Swap(ref a, ref b);
            Swap(ref a, ref c);

            //int a = 3;
            //Swap(ref a, ref 6); 
        }

        private void Swap(ref int a, ref int b)
        {
            int aCopy;
            aCopy = a;
            a = b;
            b = aCopy;
        }
    }
}
