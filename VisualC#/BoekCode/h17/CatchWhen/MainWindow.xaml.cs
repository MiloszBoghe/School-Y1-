using System.Windows;

namespace CatchWhen
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
            string email = emailTextBox.Text;

            try
            {
                CheckAddress(email);
            }
            catch(InvalidEmailException ex) when (ex.Severity <= 10)
            {
                MessageBox.Show("Please enter a valid address");
            }
            catch (InvalidEmailException ex) when (ex.Severity > 10)
            {
                Log(ex.Message);
            }

            //try
            //{
            //    CheckAddress(email);
            //}
            //catch (InvalidEmailException ex)
            //{
            //    if (ex.Severity <= 10)
            //    {
            //        MessageBox.Show("Please enter a valid address");
            //    }
            //    else
            //    {
            //        Log(ex.Message);
            //    }
            //}
        }

        private void Log(string message)
        {
            // dummy methode
            // write message to a log file
        }

        private void CheckAddress(string email)
        {
            // dummy code to simulate checks
            var ex = new InvalidEmailException(email + " does not contain @-sign");
            ex.Severity = 10;
            throw ex;
        }
    }
}
