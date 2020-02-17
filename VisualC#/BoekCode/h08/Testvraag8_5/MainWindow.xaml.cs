using System;
using System.Windows;

namespace Testvraag8_5
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
            int m, n;
            n = 10;
            m = 5;

            while ((n > 0) || (m > 0))
            {
                n--;
                m--;
            }

            string result = $"n = {n} en m = {m}";
            MessageBox.Show(result);
        }
    }
}
