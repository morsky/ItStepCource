using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace PhoneBook
{
    class Program
    {
        static void Main()
        {
            PhoneBook book = new PhoneBook();

            ReadInput(book);

            RunCommands(book);
        }
        
        private static void RunCommands(PhoneBook book)
        {
            using (StreamReader reader = new StreamReader("../../commands.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] input = line.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] parameters = input[1].Split(',');

                    //input = input.Select(x => x.Trim()).ToArray();
                    //parameters = parameters.Select(x => x.Trim()).ToArray();

                    if (input[0] == "find")
                    {
                        if (parameters.Length == 1)
                        {
                            string name = parameters[0];
                            var listOfPersons = book.Find(name);

                            CheckIfEmpty(listOfPersons);

                            Print(listOfPersons);
                        }
                        else
                        {
                            string name = parameters[0];
                            string town = parameters[1].Trim();
                            var listOfPersons = book.Find(name, town);

                            CheckIfEmpty(listOfPersons);

                            Print(listOfPersons);
                        }
                    }
                    else if (input[0] == "serialize")
                    {
                        string[] inputPrameters = input[1].Split(',');
                        string name = inputPrameters[0];
                        string fileName = inputPrameters[1].Trim();
                        string serializationType = inputPrameters[2].Trim();

                        var personToSerialize = book.Find(name);

                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            foreach (var item in personToSerialize)
                            {
                                string json = JsonConvert.SerializeObject(item);
                                Console.WriteLine(json);

                                writer.WriteLine(json);
                            }
                        }
                    }
                }
            }
        }

        private static void CheckIfEmpty(List<Person> listOfPersons)
        {
            if (listOfPersons.Count == 0)
            {
                Console.WriteLine("Not found!");
            }
        }

        private static void Print(List<Person> listOfPersons)
        {
            IPrinter<Person> list = new Print<Person>();
            list.PrintLineResult(listOfPersons);
        }

        private static void ReadInput(PhoneBook book)
        {
            //PhoneBook book1 = new PhoneBook();
            FileReader reader = new FileReader();
            Parser parser = new Parser();
            book = parser.Parse(reader);
            //using (StreamReader reader = new StreamReader("../../input.txt"))
            //{
            //    string line;

            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Person person = new Person();
            //        string[] input = line.Split('|');

            //        string name = input[0].Trim();
            //        string town = input[1].Trim();
            //        string phone = input[2].Trim();

            //        person.Name = name;
            //        person.Town = town;
            //        person.PhoneNumber = phone;

            //        book.Add(person);
            //    }
            //}
        }
    }
}