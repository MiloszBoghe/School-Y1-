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

namespace EurosAndCentsFormatted
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int cents;
            cents = Convert.ToInt32(amountTextBox.Text);

            int euros = cents / 100;
            cents = cents % 100;

            resultsLabel.Content = $"{euros} euros and {cents} cents";
            //resultsLabel.Content = $"{euros,15} euros and {cents,-15} cents";

            //double eurosCurrency = (double)cents;
            //resultsLabel.Content = $"{eurosCurrency:c}";
            //resultsLabel.Content = $"{euros:d}";
            //resultsLabel.Content = $"{123.45:0.00}";

            //int amount = Convert.ToInt32(amountTextBox.Text);
            //resultsLabel.Content = $"{amount / 100} euros and {amount % 100} cents";
        }
    }
}
