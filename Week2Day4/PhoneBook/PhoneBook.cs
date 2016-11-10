using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneBook
    {
        private HashSet<Person> PhoneCatalogue = new HashSet<Person>();

        public void Add(Person person)
        {
            PhoneCatalogue.Add(person);
        }
    }
}