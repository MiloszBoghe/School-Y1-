using System;
using System.Windows;

namespace Exercise14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string ConvertNumberToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }
        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            binaryLabel.Content = ConvertNumberToBinary(12);

        }
    }
}
