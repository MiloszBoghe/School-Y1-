using System;
using System.Collections.Generic;
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

namespace VB1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            itemListBox.FontSize = 20;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem newItem = new ListBoxItem();
            newItem.Content = itemTextBox.Text;
            itemListBox.Items.Add(newItem);

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
