using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace SphereAndBubble
{
    public class Sphere
    {
        protected int xCoord = 100;
        protected int yCoord = 100;
        protected Ellipse ellipse;

        public int X
        {
            set { xCoord = value; Redraw(); }
        }

        public int Y
        {
            set { yCoord = value; Redraw(); }
        }

        public virtual void CreateEllipse(Canvas drawingCanvas)
        {
            ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2,
                Width = 40,
                Height = 40,
                Margin = new Thickness(xCoord, yCoord, 0, 0)
            };
            drawingCanvas.Children.Add(ellipse);
        }

        public virtual void Redraw()
        {
            if (ellipse != null)
            {
                ellipse.Margin = new Thickness(xCoord, yCoord, 0, 0);
            }
        }
    }
}
