using System.Windows;
using System.Windows.Controls;

namespace CyberspaceInvader
{
    public class Alien : Sprite
    {
        private Image alienImage;
        private int stepSize;
        private Canvas canvas;
        
        public Alien()
        {
            alienImage = new Image { Source = CreateBitmap(@"Assets\Alien.gif") };
            stepSize = 3;

            Width = 25;
            Height = 25;
            IsDead = false; 
        }

        public bool IsDead { get; set; }
        
        public override void DisplayOn(Canvas drawingCanvas)
        {
            X = Width / 2;
            Y = Height / 2;
            drawingCanvas.Children.Add(alienImage);
            canvas = drawingCanvas;
        }

        public void Move()
        {
            if ((X > 480) || (X < 0))
            {
                stepSize = -stepSize;
            }
            X += stepSize;
        }

        public void DropBomb(BombCollection bombs)
        {
            var bombX = X + (Width / 2);
            var bombY = Y + Height;
            Bomb bomb = new Bomb(bombX, bombY, bombs);
            bomb.DisplayOn(canvas);
        }

        protected override void UpdateElement()
        {
            alienImage.Margin = new Thickness(X, Y, 0, 0);
            alienImage.Width = Width;
            alienImage.Height = Height;
        }
    }
}
