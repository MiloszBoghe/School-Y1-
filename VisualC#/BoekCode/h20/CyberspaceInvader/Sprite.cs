using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CyberspaceInvader
{
    public abstract class Sprite
    {
        private int x, y, width, height;

        public int X
        {
            get => x;
            set { x = value; UpdateElement(); }
        }
        
        public int Y
        {
            get => y;
            set { y = value; UpdateElement(); }
        }

        public int Width
        {
            get => width;
            set { width = value; UpdateElement(); }
        }

        public int Height
        {
            get => height;
            set { height = value; UpdateElement(); }
        }

        public abstract void DisplayOn(Canvas drawingCanvas);
        protected abstract void UpdateElement();

        protected BitmapImage CreateBitmap(string imagepath)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(imagepath, UriKind.RelativeOrAbsolute);
            bi.EndInit();
            return bi;
        }

        protected bool HasHit(Sprite otherSprite)
        {
            if (IsOnTheLeftOf(otherSprite)) return false;
            if (IsOnTheRightOf(otherSprite)) return false;
            if (IsAbove(otherSprite)) return false;
            if (IsBelow(otherSprite)) return false;

            return true;
        }

        private bool IsBelow(Sprite otherSprite)
        {
            return Y > otherSprite.Y + Height;
        }

        private bool IsAbove(Sprite otherSprite)
        {
            return Y + Height < otherSprite.Y;
        }

        private bool IsOnTheRightOf(Sprite otherSprite)
        {
            return X + Width > otherSprite.X + otherSprite.Width;
        }

        private bool IsOnTheLeftOf(Sprite otherSprite)
        {
            return X < otherSprite.X;
        }
    }
}
