using System;
using System.Windows;

namespace WordToNumber
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

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(Convert.ToString(WordToNumber("hXndred")));
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private int WordToNumber(string word)
        {
            int result = 0;
            switch (word)
            {
                case "ten":
                    result = 10;
                    break;
                case "hundred":
                    result = 100;
                    break;
                case "thousand":
                    result = 1000;
                    break;
                default:
                    throw new FormatException($"Wrong input: {word}");
            }
            return result;
        }
    }
}
