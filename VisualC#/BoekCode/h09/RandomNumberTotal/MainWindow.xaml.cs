using System;
using System.Windows;

namespace RandomNumberTotal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int generatedNumber;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            var random = new Random();
            generatedNumber = random.Next(5, 100);

            generateTextBlock.Text = $"{generatedNumber}";
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= generatedNumber; i++)
            {
                sum = sum + i;
            }
            sumTextBlock.Text = $"De som van 1 tot en met {generatedNumber} is {sum}";
        }
    }
}
