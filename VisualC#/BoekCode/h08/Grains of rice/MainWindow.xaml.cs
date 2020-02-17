using System;
using System.Windows;

namespace Grains_of_rice
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
            int numberOfSquares = 1;
            int amountOfRice = 1;
            int total = 1;
            resultTextBox.Clear();
            DisplayCounts(numberOfSquares, amountOfRice);

            while (total < 100)
            {
                numberOfSquares = numberOfSquares + 1;
                amountOfRice = amountOfRice * 2;
                DisplayCounts(numberOfSquares, amountOfRice);
                total = total + amountOfRice;
            }

            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText($"Number of squares to make total of 100 is {numberOfSquares}");
        }

        private void DisplayCounts(int square, int rice)
        {
            resultTextBox.AppendText($"On square {square} are {rice} grains");
            resultTextBox.AppendText(Environment.NewLine);
        }
    }
}
