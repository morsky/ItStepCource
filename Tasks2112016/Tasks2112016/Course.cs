using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks2112016
{
    class Course
    {
        private static int mcourceId = 0;
        public List<Student> allStudents = new List<Student>();

        public int Capacity { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int CourceId { get; private set; }

        public Course(string name, int duration, int capacity)
        {
            this.Name = name;
            this.Duration = duration;
            this.Capacity = capacity;
            this.CourceId = mcourceId++;
            allStudents = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (Capacity <= allStudents.Count)
            {
                throw new ArgumentException("Course " + Name + " is already full!");
            }

            allStudents.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (allStudents.Count <= 0)
            {
                throw new ArgumentException("No more students to delete!");
            }

            allStudents.Remove(student);
            Console.WriteLine("Student removed.");
        }

        public bool CheckStudent(int studentId)
        {
            return allStudents.Any(s => s.StudentId == studentId);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}