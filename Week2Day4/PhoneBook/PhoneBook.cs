using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneBook
    {
        private List<Person> PhoneCatalogue = new List<Person>();

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

        public List<Person> Find(string name)
        {
            return this.PhoneCatalogue.Where(x => x.Name.Contains(name)).ToList();
        }

        public List<Person> Find(string name, string town)
        {
            return this.PhoneCatalogue.Where(x => x.Name.Contains(name) && x.Town == town).ToList();
        }
    }
}