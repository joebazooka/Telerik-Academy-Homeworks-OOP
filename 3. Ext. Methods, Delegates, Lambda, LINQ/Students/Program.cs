using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        public struct Student
        {
            public string firstName;
            public string lastName;
            public int age;

            public Student(string firstName, string lastName)
                : this(firstName, lastName, 0)
            {
            }

            public Student(string firstName, string lastName, int age)
                : this()
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
            }
        }

        static void Main(string[] args)
        {
            Student[] students = { new Student("Ivan", "Petrov", 30), 
                                 new Student("Petar", "Petrov", 28),
                                 new Student("Petar", "Ivanov", 22),
                                 new Student("Dimityr", "Petrov", 20),
                                 new Student("Simeon", "Andeev", 15),
                                 new Student("Svetlin", "Nakov", 30),
                                 new Student("Nikolai", "Kostov", 24),
                                 new Student("Doncho", "Minkov"),
                                 new Student("Pavel", "Kolev"),
                                 new Student("Georgi", "Georgiev", 21)};

            // Exercise 3

            Student[] result = StudentFirstNameBeforeLast(students);

            Console.WriteLine("Exercise 3:\n");

            foreach (Student student in result)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }

            // Exercise 4

            result = StudentsBetween18and24(students);

            Console.WriteLine("\nExercise 4:\n");

            foreach (Student student in result)
            {
                Console.WriteLine("{0} {1} {2}", student.firstName, student.lastName, student.age); 
            }

            // Exercise 5

            Console.WriteLine("\nExercise 5:\n");

            students = students.OrderByDescending(student => student.firstName).ThenByDescending(student => student.lastName).ToArray<Student>();

            foreach (Student student in students)
            {
                Console.WriteLine("{0} {1} {2}", student.firstName, student.lastName, student.age);
            }

            // With LINQ
            /*
            students =
                (from student in students
                orderby student.firstName descending, student.lastName descending
                select student).ToArray<Student>();

            foreach (Student student in students)
            {
                Console.WriteLine("{0} {1} {2}", student.firstName, student.lastName, student.age);
            }
             */
        }

        public static Student[] StudentFirstNameBeforeLast(Student[] students)
        {
            var result =
                from student in students
                where student.firstName.CompareTo(student.lastName) < 0
                select student;

            return result.ToArray<Student>();
        }

        public static Student[] StudentsBetween18and24(Student[] students)
        {
            var result =
                from student in students
                where student.age >= 18 && student.age <= 24
                select student;

            return result.ToArray<Student>();
        }
    }
}
