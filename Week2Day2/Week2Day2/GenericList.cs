using System;

namespace Week2Day2
{
    public class GenericList<T>
    {
        private T[] initialArray;

        private int index;

        public GenericList()
        {
            this.initialArray = new T[4];
            this.index = 0;
        }

        public void Add(T element)
        {
            if (initialArray.Length <= index)
            {
                initialArray = ResizeArray(initialArray);
            }

            initialArray[index] = element;

            index++;
        }

        public void Remove(T element)
        {
            
        }

        private T[] ResizeArray(T[] array)
        {
            var newArray = new T[array.Length * 2];

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