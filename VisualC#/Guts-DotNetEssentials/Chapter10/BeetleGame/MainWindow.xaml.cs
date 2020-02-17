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

namespace Beetle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BeetleClass beetle;
        public MainWindow()
        {
            InitializeComponent();
            speedLabel.Content = Convert.ToString(speedSlider.Value);
            sizelabel.Content = Convert.ToString(sizeSlider.Value);

        }

        private void StartStopButton_Click(object sender, RoutedEventArgs e)
        {


            if (startStopButton.Content.Equals("Start"))
            {
                if (drawingCanvas.Children.Count == 0)
                {
                    beetle = new BeetleClass(Convert.ToInt32(sizeSlider.Value), speedSlider.Value);
                    beetle.drawBeetle(drawingCanvas);
                }
                beetle.StartTimer();
                startStopButton.Content = "Stop";
            }
            else if (startStopButton.Content.Equals("Stop"))
            {
                beetle.StopTimer();
                startStopButton.Content = "Start";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            beetle.movement = "up";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            beetle.movement = "down";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            beetle.movement = "left";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            beetle.movement = "right";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            beetle.StopTimer();
            drawingCanvas.Children.Clear();
            speedSlider.Value = 0.5;
            sizeSlider.Value = 10;
            startStopButton.Content = "Start";
        }

        private void SpeedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            speedLabel.Content = Convert.ToString(speedSlider.Value); 
        }

        private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sizelabel.Content = Convert.ToString(sizeSlider.Value);
        }
    }
}