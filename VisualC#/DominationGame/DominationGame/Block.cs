using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DominationGame
{
    public class Block
    {
        SolidColorBrush red = new SolidColorBrush(Colors.Red);
        SolidColorBrush blue = new SolidColorBrush(Colors.Blue);
        SolidColorBrush black = new SolidColorBrush(Colors.Black);
        
        private Player _owner;
        Rectangle _rectangle;
        
        public Block(int size, int xMargin, int yMargin)
        {
            _rectangle = new Rectangle()
            {
                Width = size,
                Height = size,
                Stroke = black,
                Margin = 
                
            };

        }

        public int Size { get; set; }
        public Player Owner
        {
            get { return _owner; }
            set{
                switch (_owner)
                {
                    case Player.Red:
                        _rectangle.Fill = red;
                        break;
                    case Player.Blue:
                        _rectangle.Fill = blue;
                        break;
                    case Player.None:
                        break;
                }
            }
    }

    public void DisplayOn(Canvas drawingCanvas)
    {
        drawingCanvas.Children.Add(_rectangle);
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public bool IsEmpty()
    {
        return Owner == Player.None;
    }

}
}
