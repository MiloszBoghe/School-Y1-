using System;
using System.Windows;

namespace Rainfall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] rainAmounts = { 7, 8, 0, 4, 3, 8, 1 };
        
        public MainWindow()
        {
            InitializeComponent();

            Display();
            ShowLargest();
        }

        private void Display()
        {
            rainfallTextBox.Clear();
            for (int dayNumber = 0; dayNumber < 7; dayNumber++)
            {           
                rainfallTextBox.AppendText($"day {dayNumber} rain {rainAmounts[dayNumber]}");
                rainfallTextBox.AppendText(Environment.NewLine);
            }
        }

        private void ModifyAmount()
        {
            int index = Convert.ToInt32(indexTextBox.Text);
            int data = Convert.ToInt32(valueTextBox.Text);
            rainAmounts[index] = data;
            Display();
            ShowLargest();
        }

        private void ShowLargest()
        {
            int largest = rainAmounts[0];
            for (int index = 1; index < 7; index++)
            {
                if (largest < rainAmounts[index])
                {
                    largest = rainAmounts[index];
                }
            }
            largestLabel.Content = $"Largest value is {largest}";
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            ModifyAmount();
        }

        //Testvraag 14.7:
        //private void ShowWeekTotal()
        //{
        //    int total = 0;
        //    foreach (int rainAmount in rainAmounts)
        //    {
        //        total += rainAmount;
        //    }
        //    totalLabel.Content = $"Week total is: {total}";
        //}
    }
}
