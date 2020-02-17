using System;
using System.Windows;

namespace FormatDemo
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

        private void intButton_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(intTextBox.Text);
            resultLabel.Content = "{0:" + formatTextBox.Text + "} wordt " +
                               String.Format("{0:" + formatTextBox.Text + "}", i);
        }

        private void doubleButton_Click(object sender, RoutedEventArgs e)
        {
            double d = Convert.ToDouble(doubleTextBox.Text);
            resultLabel.Content = "{0:" + formatTextBox.Text + "} wordt " +
                               String.Format("{0:" + formatTextBox.Text + "}", d);
        }
    }
}
