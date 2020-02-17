using System;
using System.Windows;
using System.Windows.Controls;

namespace SomEnVerschil
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int number1, number2;

            number1 = Convert.ToInt32(number1TextBox.Text);
            number2 = Convert.ToInt32(number2TextBox.Text);

            //sum = ComputeSum(number1, number2);
            //difference = ComputeDifference(number1, number2);

            ComputeSumAndDifference(number1, number2, out int sum, out int difference);
            sumLabel.Content = Convert.ToString(sum);
            differenceLabel.Content = Convert.ToString(difference);
        }

        private int ComputeSum(int n1, int n2)
        {
            return n1 + n2;
        }

        private int ComputeDifference(int n1, int n2)
        {
            return n1 - n2;
        }

        private void ComputeSumAndDifference(int n1, int n2, out int s, out int d)
        {
            s = n1 + n2;
            d = n1 - n2;
        }

        private void ShowSum(Label display, int n1, int n2)
        {
            display.Content = Convert.ToString(n1 + n2);
        }
    }
}
