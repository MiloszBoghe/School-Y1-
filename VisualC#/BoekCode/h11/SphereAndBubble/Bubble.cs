using System.Windows;

namespace SphereAndBubble
{
    public class Bubble : Sphere
    {
        protected int radius = 60;

        public int Size
        {
            set { radius = value; Redraw(); }
        }

        public override void Redraw()
        {
            if (ellipse != null)
            {
                ellipse.Margin = new Thickness(xCoord, yCoord, 0, 0);
                ellipse.Width = 2 * radius;
                ellipse.Height = 2 * radius;
            }
        }

        public void MoveVertical(int amount)
        {
            yCoord += amount;
            Redraw();
        }
    }
}
