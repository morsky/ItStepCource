using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.WriteLine("Enter number of courses:");
            int coursesCounter = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter courses name, duration and capacity in format:\ncourseName//duration//capacity");

            Academy academy = new Academy();

            for (int i = 0; i < coursesCounter; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(new string[] {"//"}, StringSplitOptions.None);
                int duration = int.Parse(parts[1]);
                int capacity = int.Parse(parts[2]);
                Course course = new Course(parts[0], duration, capacity);
                academy.AddCourse(course);
            }

            Console.WriteLine("Enter number of students");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter students and ages in format\nname//age");

            for (int i = 0; i < studentCount; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(new string[] {"//"}, StringSplitOptions.None);
                int age = int.Parse(parts[1]);
                Student student = new Student(parts[0], age);
                academy.AddStudent(student);
            }

            Console.WriteLine("Sign up student for a course.\nUse format: studentID courseID");
            Console.WriteLine("Or enter 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                string[] parts = input.Split(' ');
                int studentId = int.Parse(parts[0]);
                int courseId = int.Parse(parts[1]);

                academy.SignUp(studentId, courseId);
            }

            Console.WriteLine(academy);

            //Course c1 = new Course("Test", 2, 4);
            //Course c2 = new Course("Opit", 2, 4);

            //Student st1 = new Student("ivan1", 23);
            //Student st2 = new Student("ivan2", 23);
            //Student st3 = new Student("ivan3", 23);

            ////Console.WriteLine(st1.StudentId);
            ////Console.WriteLine(st2.StudentId);
            ////Console.WriteLine(st3.StudentId);

            ////Console.WriteLine(c.CourceId);

            //Academy a = new Academy();

            //a.AddStudent(st1);
            //a.AddCourse(c1);

            //a.AddStudent(st2);
            //a.AddCourse(c2);

            //Console.WriteLine("--------");
            //a.SignUp(st1.StudentId, c1.CourceId);
            //Console.WriteLine("##@#@##");
            //a.SignUp(st2.StudentId, c1.CourceId);
            //Console.WriteLine("##@#@##");
            //a.SignUp(st1.StudentId, c2.CourceId);
            //Console.WriteLine("##@#@##");
        }
    }
}