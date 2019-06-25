using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.model
{
    class Cat : Animal
    {
        public Cat(): base() {
        }

        public Cat(String aName) : base(aName)
        {
        }

        public Cat(String aName, int age) : base(aName, age)
        {
        }
    }
}
