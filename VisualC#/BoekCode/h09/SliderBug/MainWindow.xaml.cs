using System.Windows;

namespace SliderBug
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            valueLabel.Content = $"{theSlider.Value:0.00}";
        }

        private void theSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            valueLabel.Content = $"{theSlider.Value:0.00}";
        }
    }
}
