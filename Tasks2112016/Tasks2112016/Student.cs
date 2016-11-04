using System;

namespace Tasks2112016
{
    class Student : Person
    {
        private static int mstudentId = 0;
        private Course courseId;

        public Course Course
        {
            get { return this.courseId; }

            set
            {
                if (courseId != null)
                {
                    throw new ArgumentException("Student is already signed up!");
                }

                this.courseId = value;
            }
        }

        public int StudentId { get; private set; }

        public Student(string name, int age) : base(name, age)
        {
            this.StudentId = mstudentId++;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}