using System;
using System.Windows;

namespace RandomNumberTotalBuggy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int? generatedNumber;
        private Random random;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            generatedNumber = random?.Next(5, 100);
            generateTextBlock.Text = $"{generatedNumber}";
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < generatedNumber; i++)
            {
                sum = sum + i;
            }
            sumTextBlock.Text = $"De som van 1 tot en met {generatedNumber} is {sum}";
        }
    }
}
