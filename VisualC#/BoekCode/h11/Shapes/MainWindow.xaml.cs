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

namespace Shapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Square square;
        private Circle circle;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void squareButton_Click(object sender, RoutedEventArgs e)
        {
            if (square == null)
            {
                square = new Square();
                square.CreatePhysicalShape(paperCanvas);
            }
            else
            {
                square.MoveRight();
            }
        }

        private void circleButton_Click(object sender, RoutedEventArgs e)
        {
            if (circle == null)
            {
                circle = new Circle();
                circle.CreatePhysicalShape(paperCanvas);
            }
            else
            {
                circle.MoveRight();
            }
        }
    }
}
