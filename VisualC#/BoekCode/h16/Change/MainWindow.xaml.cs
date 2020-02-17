using System.Windows;

namespace Change
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

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            string original = originalTextBox.Text;
            string from = fromTextBox.Text;
            string to = toTextBox.Text;
            resultLabel.Content = Change(original, from, to);
        }

        private string Change(string original, string fromText, string toText)
        {
            string leftBit, rightBit;
            int startSearchIndex = 0;
            int currentIndex = original.IndexOf(fromText);

            if (fromText.Length != 0)
            {
                while (currentIndex >= startSearchIndex)
                {
                    leftBit = original.Substring(0, currentIndex);
                    rightBit = original.Substring(currentIndex + fromText.Length,
                                            original.Length - currentIndex - fromText.Length);
                    //MessageBox.Show(leftBit);
                    //MessageBox.Show(rightBit);

                    original = leftBit + toText + rightBit;
                    startSearchIndex = leftBit.Length + toText.Length;
                    currentIndex = original.IndexOf(fromText);
                }
            }
            return original;
        }
    }
}
