using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Shapes
{
    public abstract class Shape
    {
        protected int xCoord, yCoord;
        protected int size;

        public void MoveRight()
        {
            xCoord += 10;
            Redraw();
        }

        public abstract void CreatePhysicalShape(Canvas drawingCanvas);

        public abstract void Redraw();
    }
}
