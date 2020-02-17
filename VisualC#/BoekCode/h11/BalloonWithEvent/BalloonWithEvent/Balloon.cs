namespace BalloonWithEvent
{
    public delegate void BalloonChangedEventHandler(int x, int y, int diameter);

    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;

        public event BalloonChangedEventHandler BalloonChanged;

        public void Initialize(int newX, int newY, int newDiameter)
        {
            x = newX;
            y = newY;
            diameter = newDiameter;
            BalloonChanged(x, y, diameter);
        }

        public void MoveRight(int xStep)
        {
            x = x + xStep;
            BalloonChanged(x, y, diameter);
        }

        public void ChangeSize(int change)
        {
            diameter = diameter + change;
            BalloonChanged(x, y, diameter);
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
                BalloonChanged(x, y, diameter);
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
                BalloonChanged(x, y, diameter);
            }
        }
    }
}
