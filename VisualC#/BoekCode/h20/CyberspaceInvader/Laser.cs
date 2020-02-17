using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CyberspaceInvader
{
    public class Laser : Sprite
    {
        private int stepSize;
        private LaserCollection laserCollection;
        private Ellipse ellipse;
        private Canvas canvas;

        public Laser(int x, int y, LaserCollection laserCollection)
        {
            ellipse = new Ellipse {Fill = new SolidColorBrush(Colors.Black)};
            stepSize = 5;
            this.laserCollection = laserCollection;

            X = x;
            Y = y;
            Width = 5;
            Height = 10;
            
            laserCollection.Add(this);
        }
        
        public override void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
            canvas = drawingCanvas;
        }

        protected override void UpdateElement()
        {
            ellipse.Width = Width;
            ellipse.Height = Height;
            ellipse.Margin = new System.Windows.Thickness(X, Y, 0, 0);
        }

        public void Move()
        {
            if (Y < 0)
            {
                laserCollection.Remove(this);
                canvas.Children.Remove(ellipse);
            }
            else
            {
                Y -= stepSize;
            }
        }

        public void CheckHit(Alien alien)
        {
            if (HasHit(alien))
            {
                alien.IsDead = true;
                laserCollection.Remove(this);
            }
        }
    }
}
