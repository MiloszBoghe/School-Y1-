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

namespace WpfApp1
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
        int total = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                total += i;
                MessageBox.Show(Convert.ToString(i));
            }
            MessageBox.Show(Convert.ToString(total));
            
        }
        
    }
}

