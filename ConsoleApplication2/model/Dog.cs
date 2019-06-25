using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.model
{
    class Dog : Animal
    {
        //public Dog() : base()
        //{
        //    //super();
        //}

        public Dog() : base("Nameless Dog")
        {
        }

        public Dog(String aName) : base(aName)
        {
            //super(aName);
        }

        public Dog(int age) : base(age)
        {

        }

        public Dog(String aName, int age) : base(aName, age)
        {
        }

        //public Dog(String aName)
        //{
        //    //super(aName);
        //}

        public String bark()
        {
            return "Hav";
        }
    }
}
