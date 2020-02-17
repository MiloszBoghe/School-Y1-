using System.Windows;
using System.Collections;

namespace AListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Bemerk: using System.Collections is nodig!
            //IList list = shoppingListBox.Items;
            //int numberOfItems = list.Count;
        }
    }
}
