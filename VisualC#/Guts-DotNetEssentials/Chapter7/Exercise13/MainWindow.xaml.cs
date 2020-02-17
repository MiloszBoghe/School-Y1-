using System;
using System.Windows;

namespace Exercise13
{
    public partial class MainWindow : Window
    {
        double btw = 0.21;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (verlaagdTariefCheckBox.IsChecked == true)
            {
                btw = 0.06;
            }
            double btwAmount = Convert.ToInt32(priceTextBox.Text) * btw;
            double totaal = Convert.ToInt32(priceTextBox.Text) + btwAmount;
            btwTextBox.Text = Convert.ToString(btwAmount);
            totalTextBox.Text = Convert.ToString(totaal);
        }
    }
}