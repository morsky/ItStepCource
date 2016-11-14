using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class Print<T> : IPrinter<T>
    {
       public void PrintLineResult(List<T> listOfPersons)
        {
            foreach (var item in listOfPersons)
            {
                Console.WriteLine(item);
            }
        }
    }
}