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

namespace Car_Park_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int carCount = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            carCount = carCount + 1;
            countLabel.Content = Convert.ToString(carCount);
        }

        private void leaveButton_Click(object sender, RoutedEventArgs e)
        {
            carCount = carCount - 1;
            countLabel.Content = Convert.ToString(carCount);
        }
    }
}
