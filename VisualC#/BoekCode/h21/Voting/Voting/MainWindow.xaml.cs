using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            VotingValidator validator = new VotingValidator();
            if (validator.Check(age))
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
