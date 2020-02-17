using System.Windows.Controls;
using System.Windows.Shapes;

namespace BalloonInterface
{
    public class Square : IDisplayable
    {
        private int x, y;
        private int size;
        private Rectangle rectangle;

        public void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(rectangle);
        }

        // other methods and properties
    }
}
