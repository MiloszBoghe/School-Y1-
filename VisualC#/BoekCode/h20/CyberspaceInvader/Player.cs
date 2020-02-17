using System.Windows.Controls;

namespace CyberspaceInvader
{
    public class Player : Sprite
    {
        private Image playerImage;
        private Canvas canvas;

        public Player()
        {
            playerImage = new Image { Source = CreateBitmap(@"Assets\Player.gif") };

            Width = 20;
            Height = 20;
            IsDead = false;
        }

        public bool IsDead { get; set; }

        public override void DisplayOn(Canvas drawingCanvas)
        {
            X = Width / 2;
            Y = (int)drawingCanvas.Height - 2 * Width;
            drawingCanvas.Children.Add(playerImage);
            canvas = drawingCanvas;
        }

        public void Move(int targetX)
        {
            X = targetX;
        }

        public void ShootLaser(LaserCollection lasers)
        {
            int laserX = X + Width / 2;
            int laserY = Y - Height;
            Laser laser = new Laser(laserX, laserY, lasers);
            laser.DisplayOn(canvas);
        }

        protected override void UpdateElement()
        {
            playerImage.Margin = new System.Windows.Thickness(X, Y, 0, 0);
            playerImage.Width = Width;
            playerImage.Height = Height;
        }
    }
}
