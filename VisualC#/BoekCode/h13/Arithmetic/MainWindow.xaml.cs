using System;
using System.Windows;
using System.Windows.Controls;

namespace Arithmetic
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

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = numberTextBox.Text;
            numberListBox.Items.Add(item);
        }

        private void largestButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = (ListBoxItem)numberListBox.Items[0];
            int largest = Convert.ToInt32(item.Content);
            int number;
            for (int index = 1; index < numberListBox.Items.Count; index++)
            {
                item = (ListBoxItem)numberListBox.Items[index];
                number = Convert.ToInt32(item.Content);
                if (number > largest)
                {
                    largest = number;
                }
            }
            largestTextBox.Text = Convert.ToString(largest);
        }

        private void sumButton_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int number;
            ListBoxItem item;

            for (int index = 0; index < numberListBox.Items.Count; index++)
            {
                item = (ListBoxItem)numberListBox.Items[index];
                number = Convert.ToInt32(item.Content);
                sum += number;
            }
            sumTextBox.Text = Convert.ToString(sum);
        }

        // alternatief met foreach
        //private void sumButton_Click(object sender, RoutedEventArgs e)
        //{
        //    int sum = 0;
        //    foreach (ListBoxItem item in numberListBox.Items)
        //    {
        //        sum += Convert.ToInt32(item.Content);
        //    }
        //    sumTextBox.Text = Convert.ToString(sum);
        //}
    }
}
