using System;
using System.Windows;
using System.Collections;
using System.Windows.Controls;

namespace ListBoxButtonsOefening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IList list;
        public MainWindow()
        {
            InitializeComponent();
            list = itemListBox.Items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string action = Convert.ToString(((Button)sender).Content);
            if (action == "Load")
            {
                list.Add("Milk");
                list.Add("Sugar");
                list.Add("Cookie");
            }
            else if (action == "Add")
            {
                list.Add("Tea");
            }
            else if (action == "Clear")
            {
                list.Clear();
            }
            else if (action == "Contains")
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
            else if (action == "IndexOf")
            {
                MessageBox.Show(Convert.ToString(list[1]));
            }
            else if (action == "LastIndexOf")
            {
                int counter = 0;
                foreach (ListBoxItem items in list)
                {
                    counter++;
                }
                MessageBox.Show(list[-1].ToString());
            }
            else if (action == "Remove")
            {
                list.Remove("Tea");
            }
            else if (action == "RemoveAt")
            {
                list.RemoveAt(1);
            }
            else if (action == "Insert")
            {
                list.Insert(1, "Inserted Tea");
            }
            else if (action == "Sort")
            {

            }
            else if (action == "Retrieve")
            {

            }
            else if (action == "Count")
            {
                MessageBox.Show(list.Count.ToString());
            }
            else if (action == "Item2")
            {

            }
        }
    }
}
