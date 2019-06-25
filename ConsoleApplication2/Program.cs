using ConsoleApplication2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog streetDog = new Dog(10);
            Dog woofy = new Dog("Woofy", 35);
            Cat meow = new Cat();
            Animal anAnimal = new Cat("Mestan");

            List<Animal> animals = new List<Animal>();

            animals.Add(streetDog);
            animals.Add(woofy);
            animals.Add(meow);
            animals.Add(anAnimal);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString() + " hash: " + animal.GetHashCode());
            }

            Animal a = new Dog("ahmet", 22);
            Animal b = new Cat("ahmet", 22);

            //char* a = malloc()
            //char* b = malloc()

            int uc = 3;
            Int32 ucc = 3;


            Console.WriteLine("uc == 3 : " + (uc == 3));
            Console.WriteLine("ucc == 3 : " + (ucc == 3));
            Console.WriteLine("ucc == uc : " + (ucc == uc));
            Console.WriteLine("A == B : " + (a == b));
            Console.WriteLine("A equals B : " + (a.Equals(b)));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());


            Dictionary<Animal, bool> animalKisirMap = new Dictionary<Animal, bool>();

            animalKisirMap.Add(woofy, true);
            animalKisirMap.Add(streetDog, false);
            animalKisirMap.Add(meow, false);
            animalKisirMap.Add(anAnimal, true);
            animalKisirMap[a] = true;
            animalKisirMap[b] = false; //uzerine yazar.


            foreach (Animal hayvan in animalKisirMap.Keys)
            {
                bool kisir = animalKisirMap[hayvan];
                Console.WriteLine(hayvan.ToString() + " kisirmi: " + kisir);
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
