using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook book = new PhoneBook();

            readInput(book);

            // sring[] personInArray = arr.Where(x => x == "Name").ToArray(); - fir find function

            //using (StreamReader reader = new StreamReader("../../commands.txt"))
            //{
            //    string line;

            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        string[] input = line.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            //    }
            //}
        }

        private static void readInput(PhoneBook book)
        {
            using (StreamReader reader = new StreamReader("../../input.txt"))
            {
                string line;
                Person person = new Person();

                while ((line = reader.ReadLine()) != null)
                {
                    string[] input = line.Split('|');

                    string name = input[0].Trim();
                    string town = input[1].Trim();
                    string phone = input[2].Trim();

                    person.Name = name;
                    person.Town = town;
                    person.PhoneNumber = phone;

                    book.Add(person);
                }
            }
        }
    }
}