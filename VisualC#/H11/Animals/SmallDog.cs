using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class SmallDog : Dog
    {
        public SmallDog(string name)
            :base(name)
        {

        }
        public override string Sound()
        {
            return "Ik ben een fucking rat";
        }
    }
}
