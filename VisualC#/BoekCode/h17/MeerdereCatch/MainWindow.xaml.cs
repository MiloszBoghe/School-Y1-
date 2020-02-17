using System;
using System.Windows;

namespace MeerdereCatch
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int bottom;
            int top = 100;
            try
            {
                bottom = Int32.Parse(bottomTextBox.Text);
                statusLabel.Content = $"Dividing into 100 gives {top / bottom}";
            }
            catch (DivideByZeroException exceptionObject)
            {
                statusLabel.Content = "Error - zero: re-enter data.";
            }
            catch (FormatException exceptionObject)
            {
                statusLabel.Content = "Error in number: re-enter.";
            }
            catch (SystemException exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }
    }
}
