using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.model
{
    abstract class Animal
    {
        private readonly String name;
        private readonly int age;

        public Animal() : this("Nameless", 1)
        {
        }

        public Animal(String aName) : this(aName, 1)
        {
        }

        public Animal(int anAge) : this("Nameless", anAge)
        {
        }
        
        public Animal(String aName, int anAge)
        {
            this.name = aName;
            this.age = anAge;
        }

        public String getName()
        {
            return name;
        }

        public override string ToString()
        {
            return "Animal: " + name + " Age: " + age;
        }

        public override bool Equals(object obj)
        {
            Animal myObj = (Animal) obj;
            bool namesEq = this.name.Equals(myObj.name);
            bool agesEq = this.age == myObj.age;
            return namesEq && agesEq;
        }

        public override int GetHashCode()
        {
            return this.age.GetHashCode() + this.name.GetHashCode();
        }
    }
}
