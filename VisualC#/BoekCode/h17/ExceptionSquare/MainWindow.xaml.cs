using System;
using System.Windows;

namespace ExceptionSquare
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double side;
            try
            {
                side = Double.Parse(sideTextBox.Text);
                statusLabel.Content = $"Area is {side * side} square units.";
            }
            catch (FormatException exception)
            {
                //MessageBox.Show(exception.ToString());
                statusLabel.Content = "Error in side, please re-enter.";
            }
        }

        //private void calculateButton_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        DoCalculation();
        //    }
        //    catch (FormatException exception)
        //    {
        //        statusLabel.Content = "Error in side, please re-enter.";
        //    }
        //}

        //private void DoCalculation()
        //{
        //    double side = Double.Parse(sideTextBox.Text);
        //    statusLabel.Content = $"Area is {side * side} square units.";
        //}

    }
}
