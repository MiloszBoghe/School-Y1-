namespace BalloonWithEventConvention
{
    public delegate void BalloonChangedEventHandler(object sender, BalloonChangedEventArgs args);

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
            BalloonChanged(this, new BalloonChangedEventArgs()
            {
                X = x,
                Y = y,
                Diameter = diameter
            });
        }

        public void MoveRight(int xStep)
        {
            x = x + xStep;
            BalloonChanged(this, new BalloonChangedEventArgs()
            {
                X = x,
                Y = y,
                Diameter = diameter
            });
        }

        public void ChangeSize(int change)
        {
            diameter = diameter + change;
            BalloonChanged(this, new BalloonChangedEventArgs()
            {
                X = x,
                Y = y,
                Diameter = diameter
            });
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
                BalloonChanged(this, new BalloonChangedEventArgs()
                {
                    X = x,
                    Y = y,
                    Diameter = diameter
                });
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
                BalloonChanged(this, new BalloonChangedEventArgs()
                {
                    X = x,
                    Y = y,
                    Diameter = diameter
                });
            }
        }
    }
}
