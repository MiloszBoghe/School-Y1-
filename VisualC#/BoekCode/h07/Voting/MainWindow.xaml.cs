using System;
using System.Windows;

namespace Voting
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

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            int age = Convert.ToInt32(ageTextBox.Text);

            if (age > 17)
            {
                decisionLabel.Content = "You may vote.";
                commentaryLabel.Content = "Congratulations.";
            }
            else
            {
                decisionLabel.Content = "You may not vote.";
                commentaryLabel.Content = "Sorry.";
            }
            signOffLabel.Content = "Best Wishes.";
        }
    }
}
