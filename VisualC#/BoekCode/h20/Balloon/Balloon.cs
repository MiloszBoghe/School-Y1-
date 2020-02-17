using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BalloonApp
{
    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int radius = 20;
        private Ellipse ellipse;

        public Balloon()
        {
            x = 50;
            y = 50;
            radius = 20;

            CreateEllipse();
            UpdateEllipse();
        }

        public void MoveUp(int yStep)
        {
            y -= yStep;
            UpdateEllipse();
        }

        public void MoveDown(int yStep)
        {
            y += yStep;
            UpdateEllipse();
        }

        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; UpdateEllipse(); }
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse.StrokeThickness = 2;
        }

        private void UpdateEllipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = radius * 2;
            ellipse.Height = radius * 2;
        }
    }
}
