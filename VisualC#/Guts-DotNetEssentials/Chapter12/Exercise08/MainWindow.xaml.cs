using System;
using System.Linq;
using System.Windows;

namespace Exercise08
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = { Convert.ToInt32(firstTextBox.Text), Convert.ToInt32(secondTextBox.Text), Convert.ToInt32(thirdTextBox.Text) };
            Array.Sort(numbers);
            int s = numbers.Sum() / 2;
            if (numbers[2] > (numbers[1] + numbers[0]))
            {
                Console.WriteLine("Deze waarden kunnen geen driehoek maken");
            }
            else
            {
                Console.WriteLine("De oppervlakte is:" + Math.Sqrt(s * (s - numbers[0]) * (s - numbers[1]) * (s - numbers[2])));
            }

        }
    }
}
