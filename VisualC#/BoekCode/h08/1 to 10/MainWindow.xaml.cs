using System;
using System.Windows;

namespace _1_to_10
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

        private void displayButton_Click(object sender, RoutedEventArgs e)
        {
            numbersTextBox.Clear();
            for (int number = 1; number <= 10; number++)
            {
                numbersTextBox.AppendText(number + Environment.NewLine);
            }
        }
    }
}
