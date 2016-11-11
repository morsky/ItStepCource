using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace PhoneBook
{
    public class PhoneBook
    {
        public List<Person> PhoneCatalogue = new List<Person>();

        public void Add(Person person)
        {
            PhoneCatalogue.Add(person);
        }

        //public void Init()
        //{

        //    var input = ReadInput();

        //    While()
        //    {
        //        if (command == "quit")
        //        {
        //            break;
        //        }
        //        var command = ReadCOmmand();
        //        ExecuteCommand(command)
        //    }

        //}

        //public void Find(List<Person> PhoneCatalogue)
        //{
        //    foreach (var item in PhoneCatalogue)
        //    {
        //        Console.WriteLine(item.Name);
        //    }
        //}
    }
}