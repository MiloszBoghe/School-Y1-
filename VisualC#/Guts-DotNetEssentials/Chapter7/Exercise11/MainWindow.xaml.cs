using System;
using System.Windows;

namespace Exercise11
{
    public partial class MainWindow : Window
    {
        Random _random1;
        Random _random2;
        public MainWindow()
        {
            _random1 = new Random(5000);
            _random2 = new Random(4999);
            InitializeComponent();

        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            randomLabel1.Content = Convert.ToString(_random1.Next());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            randomLabel2.Content = Convert.ToString(_random2.Next());
        }
    }
}
