using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Databinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IList<string> list;
        //private ObservableCollection<string> list;

        public MainWindow()
        {
            InitializeComponent();

            list = new List<string>() { "bread", "milk", "coffee" };
            //list = new ObservableCollection<string>() { "bread", "milk", "coffee" };
        }

        private void bindButton_Click(object sender, RoutedEventArgs e)
        {
            shoppingListBox.ItemsSource = list;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            //KH: bij List<string> --> geen automatische update naar ListBox
            //KH: bij ObservableCollection<string> --> wel automatische update
            list.Add("tea");
        }
    }
}
