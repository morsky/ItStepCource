using System;
using Week2.Contracts;

namespace Week2
{
    class SellectionSort : Sorter
    {
        public SellectionSort(int[] array, ILogger logger)
            :base(array, logger)
        {

        }

        public override int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            Logger.WriteLine($"Sorted on {DateTime.Now} using Selection Sort");

            return array;
        }
    }
}