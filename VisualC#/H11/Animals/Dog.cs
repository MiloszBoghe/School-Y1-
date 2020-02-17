using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name)
            :base(name)
        {

        }
        public override string Sound()
        {
            return "Woef woef";
        }

    }
}
