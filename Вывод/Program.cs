 using System;

namespace Вывод
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            int[,] array = new int[n, m];
            MassInput(array);
            Print(array);
        }
        static int[,] MassInput(int[,] array)
        {
            int n = 0;
            string[] data = Console.ReadLine().Trim().Split();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(data[n]);
                    n++;
                }
                
            }
            return array;
        }
        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
