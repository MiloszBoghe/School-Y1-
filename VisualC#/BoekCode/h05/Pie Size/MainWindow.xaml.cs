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

namespace Pie_Size
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
            int pieWidth = 8, pieLength = 6;
            IncreaseSize(ref pieWidth, ref pieLength);
            IncreaseSize(ref pieWidth, ref pieLength);
            IncreaseSize(ref pieWidth, ref pieLength);
        }

        private void IncreaseSize(ref int width, ref int length)
        {
            int area;
            width = width + 2;
            length = length + 2;
            area = width * length;

            MessageBox.Show($"Pie size: {width} by {length}. Area is {area}");
        }
    }
}
