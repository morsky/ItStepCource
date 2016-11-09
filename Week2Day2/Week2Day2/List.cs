using System;
using System.Linq;

namespace Week2Day2
{
    public class List
    {
        private int[] array;

        private int index;

        public List()
        {
            array = new int[4];
            index = 0;
        }

        public int this[int inputIndex]
        {
            get
            {
                VerifyIndex(inputIndex);

                return array[inputIndex];
            }
            set
            {
                VerifyIndex(inputIndex);

                array[inputIndex] = value;
            }
        }

        private void VerifyIndex(int inputIndex)
        {
            if (inputIndex > index)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Add(int element)
        {
            if (array.Length <= index)
            {
                array = ResizeArray(array);
            }

            array[index] = element;

            index++;
        }

        public void Remove(int element)
        {
            bool change = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (change)
                {
                    int temp = array[i];
                    array[i - 1] = array[i];
                    array[i] = temp;
                    
                } else
                {
                    if (array[i] >= array[element])
                    {                        
                        array[i] = default(int);
                        array[i] = array[i];
                        change = true;
                        this.index--;
                    }
                }
            }

            Print();
        }

        private void Print()
        {
            Console.WriteLine(string.Join(", ", this.array));
        }

        public int Get(int index)
        {
            Console.WriteLine(array[index]);

            return array[index];
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