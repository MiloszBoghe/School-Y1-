using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Shapes
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

        private void shapesCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Circle circle1 = new Circle(40, 40);
            Square square1 = new Square(180, 180);
            List<Shape> shapes = new List<Shape>();

            shapes.Add(circle1);
            shapes.Add(square1);

            foreach (Shape shape in shapes)
            {
                shape.DisplayOn(shapesCanvas);
            }
        }
    }
}
