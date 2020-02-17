using System.Windows;

namespace MessageBoxes
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

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            // warning
            MessageBox.Show("The age must be over 18!",
                            "Age is out of range!",
                            MessageBoxButton.OK,
                            MessageBoxImage.Exclamation);

            // question
            if (MessageBox.Show("Do you want to buy this?",
                            "CD Purchase",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("User clicked yes");
            }
            else
            {
                MessageBox.Show("User clicked no");
            }

            // testvraag 18.8
            if (MessageBox.Show("Is Parijs de hoofdstad van Frankrijk?",
                                "Quiz",
                                MessageBoxButton.YesNo,
                                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Ja - correct!");
            }
            else
            {
                MessageBox.Show("Sorry: verkeerd");
            }
        }
    }
}
