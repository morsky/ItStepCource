using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks2112016
{
    class Academy
    {
        public static List<Student> studentsInAcademy = new List<Student>();
        public static List<Course> coursesInAcademy = new List<Course>();

        public void AddStudent(Student student)
        {
            studentsInAcademy.Add(student);
        }

        public void AddCourse(Course course)
        {
            coursesInAcademy.Add(course);
        }

        public void SignUp(int studentID, int courseID)
        {
            Student exSt = studentsInAcademy.Find(s => s.StudentId == studentID);
            Course exCr = coursesInAcademy.Find(s => s.CourceId == courseID);

            try
            {
                if (exSt != null)
                {
                    if (exCr != null)
                    {
                        exCr.AddStudent(exSt);
                        exSt.Course = exCr;
                    }
                    else
                    {
                        throw new ArgumentException("Course does not exist");
                    }
                }
                else
                {
                    throw new ArgumentException("Student does not exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString()
        {
            coursesInAcademy = coursesInAcademy.OrderBy(c => c.Name).ToList();
            studentsInAcademy = studentsInAcademy.OrderBy(s => s.Age).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var course in coursesInAcademy)
            {
                if (course.allStudents.Count > 0)
                {
                    sb.AppendLine(course.Name + " - " + course.Duration + " hours");
                    
                    foreach (var student in studentsInAcademy)
                    {
                        if (course.CheckStudent(student.StudentId))
                        {
                            sb.AppendLine("##" + student.Name);
                        }
                    }

                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
    }
}