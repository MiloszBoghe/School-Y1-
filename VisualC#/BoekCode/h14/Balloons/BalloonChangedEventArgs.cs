using System;

namespace Balloons
{
    public class BalloonChangedEventArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Diameter { get; set; }
    }
}