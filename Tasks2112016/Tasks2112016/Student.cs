using System;

namespace Tasks2112016
{
    class Student : Person
    {
        private static int mstudentId = 0;
        private int? courceId;

        public int? Cource
        {
            get { return this.courceId; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Student is already signed up!");
                }

                this.courceId = value;
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
