using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks2112016
{
    class Program
    {
        static void Main()
        {
            //Task2();
            //Task3();
            Task4();
        }

        private static void Task2()
        {
            Console.WriteLine("Enter person's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter person's age:");
            int age = int.Parse(Console.ReadLine());

            try
            {
                Person p1 = new Person();
                Person p2 = new Person(name);
                Person p3 = new Person(name, age);

                Console.WriteLine(p1.Name);
                Console.WriteLine(p2.Name + ", " + p2.Age);
                Console.WriteLine(p3.Name + ", " + p3.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Task3()
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("quit"))
                {
                    break;
                }

                string replaceInput = input.Replace("//", ".");
                string[] splitInput = replaceInput.Split('.');
                Person person = new Person(splitInput[0], int.Parse(splitInput[1]));

                persons.Add(person);
            }

            List<Person> OrderedList = persons.Where(p => p.Age > 18).OrderBy(p => p.Name.Length).ToList();

            foreach (var p in OrderedList)
            {
                Console.WriteLine(p.Name + " " + p.Age);
            }
        }

        private static void Task4()
        {
            Student st1 = new Student("ivan1", 23);
            Student st2 = new Student("ivan2", 23);
            Student st3 = new Student("ivan3", 23);

            Console.WriteLine(st1.Cource);
            Course c = new Course("Test", 2.5f, 10);

            Console.WriteLine(st1.ToString());

            Console.WriteLine(c.ToString());

            c.AddStudent(st1);
            Console.WriteLine(st1.Cource);
        }
    }
}