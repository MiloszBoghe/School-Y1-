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

namespace First_Drawing
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
            Rectangle upperRectangle = new Rectangle();
            upperRectangle.Width = 100;
            upperRectangle.Height = 50;
            upperRectangle.Margin = new Thickness(10, 10, 0, 0);
            upperRectangle.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(upperRectangle);

            Rectangle lowerRectangle = new Rectangle();
            lowerRectangle.Width = 100;
            lowerRectangle.Height = 100;
            lowerRectangle.Margin = new Thickness(10, 75, 0, 0);
            lowerRectangle.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(lowerRectangle);
        }
    }
}
