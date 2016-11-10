using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneBook
    {
        public List<Person> PhoneCatalogue = new List<Person>();

        public void Add(Person person)
        {
            PhoneCatalogue.Add(person);
        }

        public void Find(List<Person> PhoneCatalogue)
        {
            foreach (var item in PhoneCatalogue)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}