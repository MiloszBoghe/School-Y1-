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

namespace GreaterThan
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

        private void compareButton_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(input1TextBox.Text);
            int b = Convert.ToInt32(input2TextBox.Text);

            if (a > b)
            {
                resultLabel.Content = a + " is greater than " + b;
            }
            else if (b > a)
            {
                resultLabel.Content = b + " is greater than " + a;
            }
            else
            {
                resultLabel.Content = "They are equal";
            }
        }
    }
}
