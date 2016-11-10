using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Week2Day4
{
    class FileReadAndWrite
    {
        static void Main()
        {
            SortedDictionary<string, int> collection = new SortedDictionary<string, int>();
            string input = "../../input.txt";
            string output = "../../output.txt";

            ReadFile(collection, input);

            WriteFile(collection, output);

            Console.WriteLine("Ready. Your file is in: " + output);
        }

        private static void WriteFile(SortedDictionary<string, int> collection, string output)
        {
            using (StreamWriter writer = new StreamWriter(output))
            {
                foreach (var item in collection)
                {
                    writer.Write("{0} --> {1}\n", item.Key, item.Value);
                }
            }
        }

        private static void ReadFile(SortedDictionary<string, int> collection, string input)
        {
            using (StreamReader reader = new StreamReader(input))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    char[] splitChar = { '?', '!', ' ', '.', ',' };
                    string[] text = line.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);

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
                }
            }
        }
    }
}