using System;
using Week2.Contracts;

namespace Week2
{
    class BubbleSorter : Sorter
    {
        public BubbleSorter(int[] array, ILogger logger)
            :base(array, logger)
        {

        }

        public override int[] Sort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int highValue = array[j];

                        array[j] = array[j + 1];
                        array[j + 1] = highValue;
                    }
                }
            }

            Logger.WriteLine($"Sorted on {DateTime.Now} using Bubble Sort");

            return array;
        }
    }
}