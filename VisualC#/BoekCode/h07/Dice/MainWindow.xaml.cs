using System;
using System.Windows;

namespace Dice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // if you do this in XAML, you get nullpointers on the labels
            slider1.ValueChanged += slider1_ValueChanged;
            slider2.ValueChanged += slider2_ValueChanged;

            // you can also just use one handler for both sliders
            slider1.ValueChanged += CheckWhenScroll;
            slider2.ValueChanged += CheckWhenScroll;

            CheckValues();
        }

        private void slider1_ValueChanged(object sender,
                               RoutedPropertyChangedEventArgs<double> e)
        {
            CheckValues();
        }

        private void slider2_ValueChanged(object sender,
                               RoutedPropertyChangedEventArgs<double> e)
        {
            CheckValues();
        }

        private void CheckWhenScroll(object sender,
                               RoutedPropertyChangedEventArgs<double> e)
        {
            CheckValues();
        }

        private void CheckValues()
        {
            int die1 = Convert.ToInt32(slider1.Value);
            int die2 = Convert.ToInt32(slider2.Value);
            int total = die1 + die2;
            totalLabel.Content = $"total is {total}";

            if (total == 6)
            {
                statusLabel.Content = "You have won";
            }
            else
            {
                statusLabel.Content = "You have lost";
            }
        }
    }
}
