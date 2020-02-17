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

namespace opgave4._9
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int amountGiven = Convert.ToInt32(muntTextBox.Text);
            int itemCost = Convert.ToInt32(prijsTextBox.Text);
            int change = amountGiven - itemCost;
            int twoEuros = change / 200;
            change %= 200;
            int oneEuros = change / 100;
            change %= 100;
            int fiftyCents = change / 50;
            change %= 50;
            int twentyCents = change / 20;
            change %= 20;
            int tenCents = change / 10;
            change %= 10;
            int fiveCents = change / 5;
            change %= 5;
            int twoCents = change / 2;
            change %= 2;
            int cents = change;

            MessageBox.Show($"Number of 2 euro coins is: {twoEuros}\n" +
               $"Number of 1 euro coins is {oneEuros}\n" +
               $"Number of 50 cent coins is {fiftyCents}\n" +
               $"Number of 20 cent coins is {twentyCents}\n" +
               $"Number of 10 cent coins is {tenCents}\n" +
               $"Number of 5 cent coins is {fiveCents}\n" +
               $"Number of 2 cent coins is {twoCents}\n" +
               $"Number of cents left is {cents}\n", "Result!");
        }
    }
}
