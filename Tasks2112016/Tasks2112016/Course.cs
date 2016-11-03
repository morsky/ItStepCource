using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks2112016
{
    class Course
    {
        private static int mcourceId = 0;
        private List<Student> allStudents = new List<Student>();

        public int Capacity { get; set; }
        private int SignedStudents { get; set; }
        private string Name { get; set; }
        private float Duration { get; set; }
        public int CourceId { get; private set; }

        public Course(string name, float duration, int capacity)
        {
            this.Name = name;
            this.Duration = duration;
            this.Capacity = capacity;
            this.CourceId = mcourceId++;
        }

        public void AddStudent(Student student)
        {
            if (Capacity <= allStudents.Count)
            {
                throw new ArgumentException("Course {0} is already full!", Name);
            }

            allStudents.Add(student);
            Console.WriteLine("Student added.");
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
