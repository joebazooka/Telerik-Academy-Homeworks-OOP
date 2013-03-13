using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            // Initialize 10 Students
            List<Student> students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student(((char)rand.Next(97, 123)).ToString(),
                                        ((char)rand.Next(97, 123)).ToString(),
                                        rand.Next(1, 13)));
            }

            // Initialize 10 Workers
            List<Worker> workers = new List<Worker>();

            for (int i = 0; i < 10; i++)
            {
                workers.Add(new Worker(((char)rand.Next(97, 123)).ToString(),
                                        ((char)rand.Next(97, 123)).ToString(),
                                        200 + rand.NextDouble() * 600,
                                        2 + rand.NextDouble() * 10));
            }

            // Sort Students by grade in ascending order
            students =
                (from student in students
                 orderby student.Grade
                 select student).ToList<Student>();

            // Sort Workers by MoneyPerHour in descending order
            workers =
                (from worker in workers
                 orderby worker.MoneyPerHour() descending
                 select worker).ToList<Worker>();

            // Merge the Students and the Workers
            List<Human> humans = new List<Human>();

            foreach (Student student in students)
            {
                humans.Add(student);
            }
            foreach (Worker worker in workers)
            {
                humans.Add(worker);
            }

            // Sort Humans by first and last name
            humans =
            (from human in humans
             orderby human.FirstName, human.LastName
             select human).ToList<Human>();

            // Print the students, workers and humans
            Console.WriteLine("Students:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nWorkers:");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("\nHumans:");
            foreach (Human human in humans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
