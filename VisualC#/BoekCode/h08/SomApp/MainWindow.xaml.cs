using System.Windows;

namespace SomApp
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
            int sum = 0;

            for (int number = 1; number <= 100; number++)
            {
                sum = sum + number;
            }
            sumTextBox.Text = $"The sum is {sum}";
        }
    }
}
