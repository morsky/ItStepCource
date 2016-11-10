using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Contracts;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            ILogger logger = new ConsoleWriter();

            //SellectionSort sa = new SellectionSort(array, logger);
            //sa.Sort(array);

            BubbleSorter sa1 = new BubbleSorter(array, logger);
            sa1.Sort(array);

            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}