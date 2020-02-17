using System;

namespace BalloonWithEventConvention
{
    public class BalloonChangedEventArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Diameter { get; set; }
    }
}