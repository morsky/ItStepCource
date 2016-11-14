using System;

namespace PhoneBook
{
    public class Parser : IParser
    {
        public PhoneBook Parse(IReader reader)
        {
            PhoneBook book = new PhoneBook();

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Person person = new Person();
                string[] input = line.Split('|');

                string name = input[0].Trim();
                string town = input[1].Trim();
                string phone = input[2].Trim();

                person.Name = name;
                person.Town = town;
                person.PhoneNumber = phone;

                book.Add(person);
            }

            return book;
        }
    }
}