using System.Windows;

namespace TheSafe
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

        private void unlockButton_Click(object sender, RoutedEventArgs e)
        {
            string code = codeTextBox.Text;
            statusLabel.Content = "";

            if (code == "bill")
            {
                statusLabel.Content = "Unlocked";
            }
        }
    }
}
