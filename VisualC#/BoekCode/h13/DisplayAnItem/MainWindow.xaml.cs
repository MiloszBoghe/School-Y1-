using System;
using System.Windows;
using System.Windows.Controls;

namespace DisplayAnItem
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
            int index = Convert.ToInt32(indexTextBox.Text);
            ListBoxItem item = (ListBoxItem)shoppingListBox.Items[index];
            valueTextBox.Text = Convert.ToString(item.Content);
        }
    }
}
