using System;
using System.Windows;

namespace InterestCalculation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int year = 1;
        private double oldAmount;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void yearButton_Click(object sender, RoutedEventArgs e)
        {
            double rate, newAmount;
            int euros, cents;

            if (year == 1)
            {
                oldAmount = Convert.ToDouble(initialAmountTextBox.Text);
            }

            rate = Convert.ToDouble(rateTextBox.Text);

            newAmount = oldAmount + (oldAmount * rate / 100);

            euros = (int)newAmount;
            cents = (int)Math.Round(100 * (newAmount - euros));
            string line = $"After {year} years the money has become " +
                          $"{euros} euros and {cents} eurocents.";
            resultTextBox.AppendText(line);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText(Environment.NewLine);

            oldAmount = newAmount;
            year += 1;
        }
    }
}
