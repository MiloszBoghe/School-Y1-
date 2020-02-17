using System.Windows;
using System.Collections.Generic;
using System;

namespace ListBoxButtonsOefening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<string>();
            itemListBox.ItemsSource = list;
            LoadButton_Click(null, null);
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            list.Add("Sugar");
            list.Add("Cookie");
            refreshItemBox();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            list.Add("Tea");
            list.Add("Bread");
            list.Add("Milk");
            list.Add("Coffee");
            refreshItemBox();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            refreshItemBox();
        }

        private void ContainsButton_Click(object sender, RoutedEventArgs e)
        {
            if (list.Contains("Tea"))
            {
                MessageBox.Show("Tea gevonden");
            }
            else
            {
                MessageBox.Show("Tea niet gevonden");
            }
        }

        private void IndexOfButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(list.IndexOf("Cookie").ToString());
        }

        private void LastIndexOfButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            list.Remove("Tea");
            refreshItemBox();
        }

        private void RemoveAtButton_Click(object sender, RoutedEventArgs e)
        {
            list.RemoveAt(1);
            refreshItemBox();
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            list.Insert(1, "Inserted Tea");
            refreshItemBox();
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            list.Sort();
            refreshItemBox();
        }

        private void RetrieveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CountButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(list.Count.ToString());
        }

        private void Item2Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void refreshItemBox()
        {
            itemListBox.Items.Refresh();
        }
    }
}
