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

namespace Opgave4._11
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            //int number = Convert.ToInt32(intGetal.Text);
            //binaryTextbox.Text = Convert.ToString(number,2);
            string result = "";
            int amount = Convert.ToInt32(intGetal.Text);
            while (amount > 0)
            {
                result = (amount % 2) + result;
                amount /= 2;
            }
            binaryTextbox.Text = result;
        }
    }
}
