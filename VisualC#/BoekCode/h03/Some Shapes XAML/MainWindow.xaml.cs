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

namespace Some_Shapes_XAML
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
            upperRectangle.Visibility = Visibility.Visible;
            lowerRectangle.Visibility = Visibility.Visible;
            lineInRectangle.Visibility = Visibility.Visible;
            ellipseInRectangle.Visibility = Visibility.Visible;
            lowerLeftEllipse.Visibility = Visibility.Visible;
            rightImage.Visibility = Visibility.Visible;
        }
    }
}
