using System;

namespace Week2Day2
{
    public class List
    {
        private int[] initialArray;

        private int index;

        public List()
        {
            this.initialArray = new int[4];
            this.index = 0;
        }

        public void Add(int element)
        {
            if (initialArray.Length <= index)
            {
                initialArray = ResizeArray(initialArray);
            }

            initialArray[index] = element;

            index++;
        }

        public void Remove(int element)
        {
            bool change = false;

            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] >= initialArray[element])
                {
                    //initialArray[i] = initialArray[i + 1];
                    //continue;
                    //int temp = initialArray[i];
                    initialArray[i] = 0;
                    change = true;
                }

                if (change)
                {
                    int temp = initialArray[i];
                    initialArray[i] = initialArray[i];
                }

                initialArray[i] = initialArray[i];
            }
        }

        public void Get(int element)
        {
            int value = initialArray[element];
            Console.WriteLine(value);
        }

        private int[] ResizeArray(int[] array)
        {
            int[] newArray = new int[array.Length * 2];

            for (int i = 0; i <= newArray.Length; i++)
            {
                if (i == array.Length)
                {
                    break;
                }

                newArray[i] = array[i];
            }

            return newArray;
        }
    }
}