using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public Animal(string name)
        {
            this.name = name;
        }
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract string Sound();

        public override abstract string ToString();
    }
}
