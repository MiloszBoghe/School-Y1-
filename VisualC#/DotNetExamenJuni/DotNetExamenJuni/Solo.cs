using System.Collections.Generic;

namespace DotNetExamenJuni
{
    public class Solo : Performer
    {
        public Solo(string name, string type, int reservation, string start, string end, int[] techSupplies, IList<string> rider) 
            : base(name, reservation, start, end, techSupplies, rider)
        {
            Type = type;
        }

        public string Type { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
