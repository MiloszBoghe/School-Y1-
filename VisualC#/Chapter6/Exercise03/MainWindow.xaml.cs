using System;
using System.Windows;

namespace Exercise03
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        private int sum;
        private int avg;
        private double count;
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            count++;
            randomTextBox.Text = Convert.ToString(random.Next(200,401));
            sum += Convert.ToInt32(randomTextBox.Text);
            sumTextBox.Text = Convert.ToString(sum);
            averageTextBox.Text = Convert.ToString(Convert.ToInt32(sumTextBox.Text) / count);
        }
    }
}
