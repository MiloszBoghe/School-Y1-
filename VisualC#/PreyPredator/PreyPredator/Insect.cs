using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PreyPredator
{
    public abstract class Insect : IDisplayable
    {
        private Canvas _canvas;
        private Color _color;
        private Ellipse _ellipse;

        public Insect(int x, int y)
        {
            Position = new Position(x, y);
            Age = 0;
        }

        public Position Position { get; set; }
        public int Age { get; set; }

        public void MoveUp()
        {
            Position.MoveUp();
        }
        public void MoveDown()
        {
            Position.MoveDown();
        }
        public void MoveLeft()
        {
            Position.MoveLeft();
        }
        public void MoveRight()
        {
            Position.MoveRight();
        }

        public void DisplayOn(Canvas canvas, Color color)
        {
            _canvas = canvas;
            _color = color;
            double marginLeft = Position.X == 0 ? 0 : Position.X *(_canvas.Width / 16);
            double marginTop = Position.Y == 0 ? 0 : Position.Y*(_canvas.Height / 16);

            Ellipse ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(color),
                Fill = new SolidColorBrush(color),
                Width = 10,
                Height = 10,
                ClipToBounds = true,
                Margin = new System.Windows.Thickness(marginLeft,marginTop,0,0)
            };
            _ellipse = ellipse;
            
            _canvas.Children.Add(ellipse);

        }

        public void StopDisplaying()
        {
            _canvas.Children.Remove(_ellipse);
        }

        public void UpdateDisplay()
        {
            StopDisplaying();
            DisplayOn(_canvas, _color);
        }
    }


}
