using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lussen
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            numbersTextBox.Clear();
            while (count <= 9)
            {
                numbersTextBox.AppendText(count + " ");
                count++;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            numbersTextBox.Clear();
            for (int count = 0; count <= 9; count++)
            {
                numbersTextBox.AppendText(count + " ");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            numbersTextBox.Clear();
            do
            {
                numbersTextBox.AppendText(count + " ");
                count++;
            } while (count <= 9);
        }
    }
}
