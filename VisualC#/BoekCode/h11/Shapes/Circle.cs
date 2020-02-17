using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Shapes
{
    public class Circle : Shape
    {
        private Ellipse ellipse;

        public Circle()
        {
            xCoord = 40;
            yCoord = 40;
            size = 80;
        }

        public override void CreatePhysicalShape(Canvas drawingCanvas)
        {
            ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2,
                Width = size,
                Height = size,
                Margin = new Thickness(xCoord, yCoord, 0, 0)
            };

            drawingCanvas.Children.Add(ellipse);

        }

        public override void Redraw()
        {
            if (ellipse != null)
            {
                ellipse.Margin = new Thickness(xCoord, yCoord, 0, 0);
                ellipse.Height = size;
                ellipse.Width = size;
            }
        }
    }
}
