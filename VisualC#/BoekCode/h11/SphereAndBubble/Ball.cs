namespace SphereAndBubble
{
    public class Ball : Sphere
    {
        public void MoveLeft(int amount)
        {
            xCoord -= amount;
            Redraw();
        }

        public void MoveRight(int amount)
        {
            xCoord += amount;
            Redraw();
        }
    }
}
