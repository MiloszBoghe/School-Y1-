namespace FindBalloons
{
    public delegate void BalloonChangedEventHandler(object sender, BalloonChangedEventArgs args);

    public class Balloon
    {
        private int x;
        private int y;
        private int diameter;

        public event BalloonChangedEventHandler BalloonChanged;

        public int Diameter { get => diameter; set => diameter = value; }

        public void Initialize(int newX, int newY, int newDiameter)
        {
            x = newX;
            y = newY;
            Diameter = newDiameter;
            BalloonChanged(this, new BalloonChangedEventArgs()
            {
                X = x,
                Y = y,
                Diameter = Diameter
            });
        }

        public void ChangeSize(int change)
        {
            Diameter = Diameter + change;
            BalloonChanged(this, new BalloonChangedEventArgs()
            {
                X = x,
                Y = y,
                Diameter = Diameter
            });
        }
    }
}
