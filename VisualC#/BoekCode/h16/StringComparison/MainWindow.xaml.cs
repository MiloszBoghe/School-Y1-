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

namespace StringComparison
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
            if (string1TextBox.Text.CompareTo(string2TextBox.Text) < 0)
            {
                resultLabel.Content = string1TextBox.Text + " komt voor " +
                                   string2TextBox.Text;
            }
            else
            {
                resultLabel.Content = string2TextBox.Text + " komt voor " +
                                   string1TextBox.Text;
            }
        }
    }
}
