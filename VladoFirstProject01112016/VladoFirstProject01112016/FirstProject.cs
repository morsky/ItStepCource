using System;

namespace VladoFirstProject01112016
{
    class FirstProject
    {
        static void Main()
        {
            string input = Console.ReadLine();            
            int cells;

            while (!Int32.TryParse(input, out cells))
            {
                input = Console.ReadLine();
            }

            int[][] array = FillMatrix(cells);

            PrintMatrix(array);
            Console.WriteLine("--------------------------");         

            while (true)
            {
                string coordinates = Console.ReadLine();

                if (string.IsNullOrEmpty(coordinates))
                {
                    Console.WriteLine("See you next time!");

                    break;
                }

                string[] separateCoordinates = coordinates.Split(' ');

                int x = Int32.Parse(separateCoordinates[0]);
                int y = Int32.Parse(separateCoordinates[1]);
                array[x][y]++;

                Console.WriteLine("+++++++++++++++++++++++++++++");
                Console.WriteLine(array[x][y]);
                Console.WriteLine("+++++++++++++++++++++++++++++");

                Console.WriteLine("-----------------------------");
                PrintMatrix(array);
            } 
        }

        static int[][] FillMatrix(int cells)
        {
            int[][] array = new int[cells][];
            int count = 0;

            for (int i = 0; i < cells; i++)
            {
                array[i] = new int[cells];

                for (int j = 0; j < cells; j++)
                {
                    array[i][j] = count;
                    count++;
                }
            }

            return array;
        }

        static void PrintMatrix(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}