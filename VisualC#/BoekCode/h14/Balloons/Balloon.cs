namespace Balloons
{
    public delegate void BalloonChangedEventHandler(object sender, BalloonChangedEventArgs args);

    public class Balloon
    {
        private int x;
        private int y;
        private int diameter;

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
    }
}
