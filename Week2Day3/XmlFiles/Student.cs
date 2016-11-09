namespace XmlFiles
{
    class Student
    {
        private static int counter = 0;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Counter = counter++;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Counter { get; set; }
    }
}