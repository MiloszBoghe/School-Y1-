using System;
using System.Windows;

namespace Testvraag8_4_kwadraten
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
            resultTextBox.Clear();
            for (int number = 1; number <= 5; number++)
            {
                resultTextBox.AppendText($"{number} {number * number}");
                resultTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}
