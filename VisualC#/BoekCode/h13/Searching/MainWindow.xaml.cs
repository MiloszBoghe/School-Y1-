using System;
using System.Windows;
using System.Windows.Controls;

namespace Searching
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

        private void findButton_Click(object sender, RoutedEventArgs e)
        {
            int length = shoppingListBox.Items.Count;
            int index = 0;
            bool found = false;
            string searchText = findTextBox.Text;
            ListBoxItem item;

            while ((!found) && (index < length))
            {
                item = (ListBoxItem)shoppingListBox.Items[index];
                if (Convert.ToString(item.Content) == searchText)
                {
                    found = true;
                    resultLabel.Content = $"Item found, index: {index}";
                }
                else
                {
                    index++;
                }
            }
        }

        // KH: werkt niet, want je zoekt naar string in lijst en niet
        // KH: naar ListBoxItem met string in
        //private void findButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string searchText = findTextBox.Text;
        //    if (shoppingListBox.Items.Contains(searchText))
        //    {
        //        resultLabel.Content = "Item found, index: " +
        //            shoppingListBox.Items.IndexOf(searchText);
        //    }
        //}

        // KH: werkt ook niet want
        // KH: searchTextItem is een nieuw item met een te zoeken
        // KH: string en zal dus niet in de lijst gevonden worden
        //private void findButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ListBoxItem searchTextItem = new ListBoxItem();
        //    searchTextItem.Content = findTextBox.Text;
        //    if (shoppingListBox.Items.Contains(searchTextItem))
        //    {
        //        resultLabel.Content = "Item found, index: " +
        //            shoppingListBox.Items.IndexOf(searchTextItem);
        //    }
        //}
    }
}
