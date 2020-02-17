using System;
using System.Windows;
using System.Windows.Controls;

namespace LookupMonths
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

        private void lookupButton_Click(object sender, RoutedEventArgs e)
        {
            int monthNumber = Convert.ToInt32(monthNumberTextBox.Text);
            ListBoxItem item = (ListBoxItem)monthListBox.Items[monthNumber - 1];
            string monthName = Convert.ToString(item.Content);
            monthNameTextBox.Text = monthName;
        }
    }
}
