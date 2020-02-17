using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CyberspaceInvader
{
    public class Bomb : Sprite
    {
        private int stepSize;
        private BombCollection bombCollection;
        private Ellipse ellipse;
        private Canvas canvas;
        
        public Bomb(int x, int y, BombCollection bombCollection)
        {
            ellipse = new Ellipse {Fill = new SolidColorBrush(Colors.Black)};
            stepSize = 5;
            this.bombCollection = bombCollection;

            X = x;
            Y = y;
            Width = 5;
            Height = 5;
            
            this.bombCollection.Add(this);
        }

        public override void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
            canvas = drawingCanvas;
        }

        public void Move()
        {
            if (Y > canvas.Height)
            {
                bombCollection.Remove(this);
            }
            else
            {
                Y += stepSize;
            }
        }

        public void CheckHit(Player player)
        {
            if (HasHit(player))
            {
                bombCollection.Remove(this);
                player.IsDead = true;
            }
        }

        protected override void UpdateElement()
        {
            ellipse.Width = Width;
            ellipse.Height = Height;
            ellipse.Margin = new Thickness(X, Y, 0, 0);
        }
    }
}
