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
using System.Windows.Shapes;

namespace MultipleWindows
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        private MainWindow otherWindow;
        
        public DetailsWindow(MainWindow other)
        {
            InitializeComponent();
            otherWindow = other;
        }

        private void hideButton_Click(object sender, RoutedEventArgs e)
        {
            otherWindow.Hide();
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            otherWindow.Show();
        }
    }
}
