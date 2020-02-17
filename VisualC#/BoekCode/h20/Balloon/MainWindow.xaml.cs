using System;
using System.Windows;

namespace BalloonApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Balloon balloon;
        
        public MainWindow()
        {
            InitializeComponent();

            balloon = new Balloon();
            radiusSlider.Value = balloon.Radius;
            radiusLabel.Content = Convert.ToString(balloon.Radius);
            balloon.DisplayOn(balloonCanvas);
        }

        private void upButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveUp(5);
        }

        private void downButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveDown(5);
        }

        private void radiusSlider_ValueChanged(object sender,
                              RoutedPropertyChangedEventArgs<double> e)
        {
            balloon.Radius = Convert.ToInt32(radiusSlider.Value);
            radiusLabel.Content = Convert.ToString(balloon.Radius);
        }
    }
}
