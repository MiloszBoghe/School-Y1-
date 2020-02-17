using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Shapes
{
    public class Circle : Shape
    {
        private Ellipse ellipse;

        public Circle(int initX, int initY)
        {
            x = initX;
            y = initY;
            CreateEllipse();
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(ellipse);
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse()
            {
                Stroke = brush,
                Width = size,
                Height = size,
                Margin = new Thickness(x, y, 0, 0)
            };
        }
    }
}
