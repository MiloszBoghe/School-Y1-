using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Shapes
{
    public class Square : Shape
    {
        private Rectangle rectangle;

        public Square(int initX, int initY)
        {
            x = initX;
            y = initY;
            CreateRectangle();
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(rectangle);
        }

        private void CreateRectangle()
        {
            rectangle = new Rectangle()
            {
                Stroke = brush,
                Width = size,
                Height = size,
                Margin = new Thickness(x, y, 0, 0)
            };
        }
    }
}
