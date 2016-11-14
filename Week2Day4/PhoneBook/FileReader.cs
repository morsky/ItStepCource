using System.IO;

namespace PhoneBook
{
    class FileReader : IReader
    {
        public string ReadLine()
        {
            string path = "../../input.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                //while ((line = reader.ReadLine()) != null)
                //{
                //    Person person = new Person();
                //    string[] input = line.Split('|');

                //    string name = input[0].Trim();
                //    string town = input[1].Trim();
                //    string phone = input[2].Trim();

                //    person.Name = name;
                //    person.Town = town;
                //    person.PhoneNumber = phone;

                //    //book.Add(person);


                //}
                return reader.ReadLine();
            }
        }
    }
}