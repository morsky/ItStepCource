using System.Collections.Generic;

namespace XmlFiles
{
    class StudentsFactory
    {
        public List<Student> Create()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", 20));
            students.Add(new Student("Gosho", 22));
            students.Add(new Student("Iva", 18));
            students.Add(new Student("Mima", 32));
            students.Add(new Student("Ivancho", 52));
            students.Add(new Student("Gogo", 25));
            students.Add(new Student("Sasho", 19));
            students.Add(new Student("Sisi", 27));
            students.Add(new Student("Eva", 36));
            students.Add(new Student("Toncho", 40));

            return students;
        }
    }
}