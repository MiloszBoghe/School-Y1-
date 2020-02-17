using System.Windows;
using System.Windows.Controls;

namespace AddAnItem
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
            // KH: werkt, maar niet ok omdat de overige items ListBoxItems zijn
            // KH: dit gaat de string rechtstreeks toevoegen
            //string newItem = itemTextBox.Text;
            //shoppingListBox.Items.Add(newItem);

            ListBoxItem newItem = new ListBoxItem();
            newItem.Content = itemTextBox.Text;
            shoppingListBox.Items.Add(newItem);
        }
    }
}
