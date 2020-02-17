using System;
using System.Windows;

namespace Exercise11
{
    public partial class MainWindow : Window
    {
        Random random1 = new Random(5000);
        Random random2 = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RandomButton1_Click(object sender, RoutedEventArgs e)
        {
            randomLabel1.Content = Convert.ToString(random1.Next());
        }

        private void RandomButton2_Click(object sender, RoutedEventArgs e)
        {
            randomLabel2.Content = Convert.ToString(random2.Next());
          

        }
    }
}
