using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook book = new PhoneBook();

            readInput(book);

            // sring[] personInArray = arr.Where(x => x == "Name").ToArray(); - for find function

            doTheCommands(book);
        }

        private static void doTheCommands(PhoneBook book)
        {
            using (StreamReader reader = new StreamReader("../../commands.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] input = line.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] parameters = input[1].Split(',');

                    if (input[0] == "find")
                    {
                        if (parameters.Length == 1)
                        {
                            string name = parameters[0];
                            Person[] ListOfPersons = FindByName(book, name);

                            Print(ListOfPersons);
                        }
                        else
                        {
                            Person[] ListOfPersons = FindByNameAndTown(book, parameters);

                            Print(ListOfPersons);
                        }
                    }
                    else if (input[0] == "serialize")
                    {
                        string[] inputPrameters = input[1].Split(',');
                        string name = inputPrameters[0];
                        string fileName = inputPrameters[1].Trim();
                        string serializationType = inputPrameters[2].Trim();

                        Person[] personToSerialize = FindByName(book, name);

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

                Console.WriteLine("Not found!");
            }
        }

        private static Person[] FindByNameAndTown(PhoneBook book, string[] parameters)
        {
            return book.PhoneCatalogue.Where(x => x.Name.Contains(parameters[0]) && x.Town == parameters[1].Trim()).ToArray();
        }

        private static Person[] FindByName(PhoneBook book, string parameters)
        {
            return book.PhoneCatalogue.Where(x => x.Name.Contains(parameters[0])).ToArray();
        }

        private static void Print(Person[] ListOfPersons)
        {
            foreach (var item in ListOfPersons)
            {
                Console.WriteLine("{0}, {1} - {2}", item.Name, item.Town, item.PhoneNumber);
            }
        }

        private static void readInput(PhoneBook book)
        {
            using (StreamReader reader = new StreamReader("../../input.txt"))
            {
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
            }
        }
    }
}