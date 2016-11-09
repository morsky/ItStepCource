using System.Collections.Generic;
using System.Xml;

namespace XmlFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            XmlNode root = document.CreateElement("students");
            document.AppendChild(root);

            StudentsFactory factory = new StudentsFactory();
            List<Student> st = factory.Create();

            for (int i = 0; i < st.Count; i++)
            {
                XmlNode students = document.CreateElement("stusent");
                root.AppendChild(students);

                XmlNode studentName = document.CreateElement("name");
                XmlAttribute id = document.CreateAttribute("id");
                id.Value = (st[i].Counter).ToString();
                students.Attributes.Append(id);
                studentName.InnerText = st[i].Name;
                students.AppendChild(studentName);

                XmlNode studentAge = document.CreateElement("age");
                studentAge.InnerText = (st[i].Age).ToString();
                students.AppendChild(studentAge);

                //XmlNode studentName = document.CreateElement("name");
                //XmlAttribute id = document.CreateAttribute("id");
                //id.Value = i.ToString();
                //students.Attributes.Append(id);
                //studentName.InnerText = "Ivan " + i;
                //students.AppendChild(studentName);

                //XmlNode studentAge = document.CreateElement("age");
                //studentAge.InnerText = (20 + i).ToString();
                //students.AppendChild(studentAge);
            }
            
            document.Save("../../students.xml");
        }
    }
}