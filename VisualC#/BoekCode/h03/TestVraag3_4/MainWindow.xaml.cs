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

namespace TestVraag3_4
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            Line horizontal = new Line();
            horizontal.X1 = 20; horizontal.Y1 = 20;
            horizontal.X2 = 120; horizontal.Y2 = 20;
            horizontal.Stroke = new SolidColorBrush(Colors.Black);
            horizontal.StrokeThickness = 4;

            Line vertical = new Line();
            vertical.X1 = 70; vertical.Y1 = 20;
            vertical.X2 = 70; vertical.Y2 = 120;
            vertical.Stroke = new SolidColorBrush(Colors.Black);
            vertical.StrokeThickness = 4;

            paperCanvas.Children.Add(horizontal);
            paperCanvas.Children.Add(vertical);
        }
    }
}
