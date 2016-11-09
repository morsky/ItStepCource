using System;
using System.Collections.Generic;

namespace Week2Day3
{
    class CountAllWordsInText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();
            char[] splitChar = { '?', '!', ' ', '.', ',' };
            string[] text = input.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> collection = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (collection.ContainsKey(text[i]))
                {
                    collection[text[i]] = collection[text[i]] + 1;
                }
                else
                {
                    collection.Add(text[i], 1);
                }
            }

            foreach (var item in collection)
            {
                Console.WriteLine("{0} --> {1}", item.Key, item.Value);
            }
        }
    }
}