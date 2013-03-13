using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal : ISound
    {
        // Fields
        private string name;
        private int age;
        private char sex;

        // Constructors
        public Animal(string name, int age, char sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        // Properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.age = value;
            }
        }

        public char Sex
        {
            get { return this.sex; }
            set
            {
                if (value != 'f' && value != 'm')
                {
                    throw new ArgumentException();
                }
                this.sex = value;
            }
        }

        // Methods
        public abstract void ProduceSound();

        public string AnimalKind()
        {
            return this.GetType().Name;
        }

        public string Introduce()
        {
            return String.Format("I am {0}, age: {1}, sex: {2}. I am {3}", 
                this.name, this.age, this.sex, this.AnimalKind());
        }

        public static double AverageAge(Animal[] animals)
        {
            return animals.Average(animal => animal.Age);
        }
    }
}
