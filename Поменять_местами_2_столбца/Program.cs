using System;

namespace Поменять_местами_2_столбца
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            int[,] array = new int[n, m];
            ArrayInput(n, m, ref array);
            string[] data1 = Console.ReadLine().Trim().Split();
            int n1 = int.Parse(data1[0]);
            int n2 = int.Parse(data1[1]);
            ChangeRows(ref array, n1 - 1, n2 - 1);
            Print(array);
        }
        static void ChangeRows(ref int[,] array, int x, int y)
        {
            int temp;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp = array[i, x];
                array[i, x] = array[i, y];
                array[i, y] = temp;
            }
        }
        static void ArrayInput(int n, int m, ref int[,] array)
        {
            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Trim().Split();
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(numbers[j]);
                }
            }
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
