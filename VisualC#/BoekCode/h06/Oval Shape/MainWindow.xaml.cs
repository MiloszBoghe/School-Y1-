using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Oval_Shape
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse ellipse;

        public MainWindow()
        {
            InitializeComponent();

            verticalSlider.Minimum = 0;
            verticalSlider.Maximum = paperCanvas.Height;

            horizontalSlider.Minimum = 0;
            horizontalSlider.Maximum = paperCanvas.Width;

            verticalLabel.Content = Convert.ToString(verticalSlider.Value);
            horizontalLabel.Content = Convert.ToString(horizontalSlider.Value);

            CreateEllipse();
            //horizontalSlider.Value = 100;
            //verticalSlider.Value = 100;

            horizontalSlider.ValueChanged += horizontalSlider_ValueChanged;
            verticalSlider.ValueChanged += verticalSlider_ValueChanged;

        }

        private void verticalSlider_ValueChanged(object sender,
                                    RoutedPropertyChangedEventArgs<double> e)
        {
            int vertical = Convert.ToInt32(verticalSlider.Value);
            verticalLabel.Content = Convert.ToString(vertical);
            UpdateEllipse();
        }
        private void horizontalSlider_ValueChanged(object sender,
                                      RoutedPropertyChangedEventArgs<double> e)
        {
            int horizontal = Convert.ToInt32(horizontalSlider.Value);
            horizontalLabel.Content = Convert.ToString(horizontal);
            UpdateEllipse();
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse()
            {
                Width = horizontalSlider.Value,
                Height = verticalSlider.Value,
                Stroke = new SolidColorBrush(Colors.GreenYellow),
                Fill = new SolidColorBrush(Colors.GreenYellow),
                Margin = new Thickness(0, 0, 0, 0)
            };
            paperCanvas.Children.Add(ellipse);
        }

        private void UpdateEllipse()
        {
            ellipse.Width = horizontalSlider.Value;
            ellipse.Height = verticalSlider.Value;
        }
    }
}