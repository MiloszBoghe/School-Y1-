using System.Collections.Generic;

namespace DotNetExamenJuni
{
    public class Band : Performer
    {
        public Band(string name, int members, int reservation, string start, string end, int[] techSupplies, IList<string> rider)
            : base(name, reservation, start, end, techSupplies, rider)
        {
            MemberCount = members;
        }

        public int MemberCount { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
