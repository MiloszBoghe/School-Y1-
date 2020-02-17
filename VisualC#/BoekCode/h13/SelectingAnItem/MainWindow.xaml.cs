using System;
using System.Windows;
using System.Windows.Controls;

namespace SelectingAnItem
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

        private void shoppingListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            numberTextBox.Text = $"{shoppingListBox.SelectedIndex}";
        }
    }
}
