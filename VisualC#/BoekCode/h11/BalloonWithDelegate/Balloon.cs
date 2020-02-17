using System;

namespace BalloonWithDelegate
{
    public delegate void BalloonDisplayer(int x, int y, int diameter);

    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;

        public BalloonDisplayer Display;

        public void Initialize(int newX, int newY, int newDiameter)
        {
            x = newX;
            y = newY;
            diameter = newDiameter;
            Display(x, y, diameter);
        }

        public void MoveRight(int xStep)
        {
            x = x + xStep;
            Display(x, y, diameter);
        }

        public void ChangeSize(int change)
        {
            diameter = diameter + change;
            Display(x, y, diameter);
        }

        public int XCoord
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                Display(x, y, diameter);
            }
        }

        public int YCoord
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                Display(x, y, diameter);
            }
        }
    }
}
