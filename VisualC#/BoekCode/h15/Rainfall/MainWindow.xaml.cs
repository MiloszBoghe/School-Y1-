using System;
using System.Windows;

namespace Rainfall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] rainData = {{10, 7, 3, 28, 5, 6, 3},
                                   {12, 3, 5, 7, 12, 5, 8},
                                   {8, 5, 2, 1, 1, 4, 7}};

        public MainWindow()
        {
            InitializeComponent();
            Display();
            //CalculateTotal();
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeValue();
        }

        private void ChangeValue()
        {
            int dayNumber = Convert.ToInt32(dayTextBox.Text);
            int location = Convert.ToInt32(locationTextBox.Text);
            int amount = Convert.ToInt32(valueTextBox.Text);
            rainData[location, dayNumber] = amount;

            Display();
            CalculateTotal();
        }

        private void Display()
        {
            dataTextBox.Clear();
            for (int locationIndex = 0; locationIndex < 3; locationIndex++)
            {
                for (int dayNumber = 0; dayNumber < 7; dayNumber++)
                {
                    dataTextBox.AppendText($"{rainData[locationIndex, dayNumber]}\t");
                }
                dataTextBox.AppendText(Environment.NewLine);
            }
        }

        private void CalculateTotal()
        {
            int total = 0;
            //for (int locationIndex = 0; locationIndex < 3; locationIndex++)
            //{
            //    for (int dayNumber = 0; dayNumber < 7; dayNumber++)
            //    {
            //        total += rainData[locationIndex, dayNumber];
            //    }
            //}
            foreach (int item in rainData)
            {
                total += item;
            }
            totalLabel.Content = $"Total rainfall is {total}";
        }

    }
}
