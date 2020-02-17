using System.Windows;

namespace Fast_Food
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

        private void onButton_Click(object sender, RoutedEventArgs e)
        {
            foodTextBox.IsEnabled = true;
        }

        private void offButton_Click(object sender, RoutedEventArgs e)
        {
            foodTextBox.IsEnabled = false;
        }

        private void toggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (foodTextBox.IsEnabled == true)
            {
                foodTextBox.IsEnabled = false;
            }
            else
            {
                foodTextBox.IsEnabled = true;
            }
        }
    }
}
