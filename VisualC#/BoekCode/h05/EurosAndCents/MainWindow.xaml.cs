using System;
using System.Windows;

namespace EurosAndCents
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
            int originalCents = Convert.ToInt32(amountTextBox.Text);
            ExtractEurosAndCents(originalCents, out int wholeEuros, out int centsLeft);
            eurosTextBlock.Text = Convert.ToString(wholeEuros);
            centsTextBlock.Text = Convert.ToString(centsLeft);
        }

        private void ExtractEurosAndCents(int totalCents,
                                          out int euros,
                                          out int centsLeft)
        {
            // int temp = euros; compile error!
            euros = totalCents / 100;
            centsLeft = totalCents % 100;
        }
    }
}
