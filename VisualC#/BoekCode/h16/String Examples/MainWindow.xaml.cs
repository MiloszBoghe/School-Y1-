using System.Windows;

namespace String_Examples
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

        private void executeButton_Click(object sender, RoutedEventArgs e)
        {
            string string1 = string1TextBox.Text;
            string string2 = string2TextBox.Text;
            int number1, number2;

            // place example code here
            string resultString = "";
            string[] words;
            char[] separators = { ',' };
            words = string1.Split(separators);
            for (int place = 0; place < words.Length; place++)
            {
                resultString += $"[{words[place].Trim()}] ";
            }

            resultLabel.Content = resultString;
        }
    }
}
