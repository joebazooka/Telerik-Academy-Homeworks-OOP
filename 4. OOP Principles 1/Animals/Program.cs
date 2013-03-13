using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog("Dog1", 1, 'm'),
                         new Dog("Dog2", 4, 'f'),
                         new Dog("Dog3", 2, 'f')};

            Cat[] cats = { new Cat("Cat1", 6, 'f'),
                         new Kitten("Cat2", 3),
                         new Tomcat("Cat3", 2)};

            Frog[] frogs = { new Frog("Frog1", 1, 'm'),
                         new Frog("Frog2", 3, 'f'),
                         new Frog("Frog3", 2, 'm')};

            Animal[] animals = new Animal[dogs.Length + cats.Length + frogs.Length];
            int ind = 0;

            foreach (Dog dog in dogs)
            {
                Console.Write("{0} and I say: ", dog.Introduce());
                dog.ProduceSound();
                animals[ind] = dog;
                ind++;
            }

            foreach (Cat cat in cats)
            {
                Console.Write("{0} and I say: ", cat.Introduce());
                cat.ProduceSound();
                animals[ind] = cat;
                ind++;
            }

            foreach (Frog frog in frogs)
            {
                Console.Write("{0} and I say: ", frog.Introduce());
                frog.ProduceSound();
                animals[ind] = frog;
                ind++;
            }

            Console.WriteLine("The Average Age of the dogs is: {0:0.00}", Animal.AverageAge(dogs));
            Console.WriteLine("The Average Age of the cats is: {0:0.00}", Animal.AverageAge(cats));
            Console.WriteLine("The Average Age of the frogs is: {0:0.00}", Animal.AverageAge(frogs));
            Console.WriteLine("The Average Age of the animals is: {0:0.00}", Animal.AverageAge(animals));
        }
    }
}
