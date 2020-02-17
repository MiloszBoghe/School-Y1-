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

namespace TestVraag4_6
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

        private void doitButton_Click(object sender, RoutedEventArgs e)
        {
            int totalSeconds = 307;
            int seconds, minutes;
            minutes = totalSeconds / 60;
            seconds = totalSeconds % 60;

            string message = String.Format("{0} minutes and {1} seconds", minutes, seconds);
            MessageBox.Show(message);
        }
    }
}
