using System;
using System.Windows;

namespace Gambling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random randomNumberGenerator = new Random();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void throwButton_Click(object sender, RoutedEventArgs e)
        {
            int die1 = randomNumberGenerator.Next(1, 7);
            int die2 = randomNumberGenerator.Next(1, 7);

            valuesLabel.Content = $"The die values are {die1} and {die2}";

            if (die1 == die2)
            {
                outcomeLabel.Content = "dice equal - a win";
            }
            else
            {
                outcomeLabel.Content = "dice not equal - lose";
            }
        }
    }
}
