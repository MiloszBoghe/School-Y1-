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
    public class Square : Shape
    {
        private Rectangle rect;

        public Square()
        {
            xCoord = 40;
            yCoord = 40;
            size = 80;
        }

        public override void CreatePhysicalShape(Canvas drawingCanvas)
        {
            rect = new Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.Black);
            rect.StrokeThickness = 2;
            rect.Width = size;
            rect.Height = size;
            rect.Margin = new Thickness(xCoord, yCoord, 0, 0);

            drawingCanvas.Children.Add(rect);

        }

        public override void Redraw()
        {
            if (rect != null)
            {
                rect.Margin = new Thickness(xCoord, yCoord, 0, 0);
                rect.Height = size;
                rect.Width = size;
            }
        }
    }
}
