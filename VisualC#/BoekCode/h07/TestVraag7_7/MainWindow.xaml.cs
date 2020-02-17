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

namespace TestVraag7_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int max = 0;

        public MainWindow()
        {
            InitializeComponent();

            volumeSlider.ValueChanged += volumeSlider_ValueChanged;
        }

        void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int volume = Convert.ToInt32(volumeSlider.Value);
            if (volume > max)
            {
                max = volume;
            }
            messageLabel.Content = "maximum value is " + max;
        }   
    }
}
