using System;

namespace Tasks2112016
{
    public class Person
    {
        private string name;
        private int age;

        public string Name { get; set; }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age should be positive!");
                }

                this.age = value;
            }
        }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(string name) : this()
        {
            this.Name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.Age = age;
        }
    }
}