using System;

namespace Среднее_арифметическое
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = Convert.ToInt32(data[0]);//рядки
            int m = Convert.ToInt32(data[1]);//стовпці
            int[,] array = new int[n, m];
            MassInput(n, m, array);
            Console.WriteLine(Average(n, m, array));
        }
        static int[,] MassInput(int n, int m, int[,] array)
        {
            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Trim().Split();
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToInt32(numbers[j]);
                }
            }
            return array;
        }
        static double Average(int n, int m, int[,] array)
        {
            double sum = 0;
            double aver = 0;
            double num = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {

                    if (i > j)
                    {
                        sum += array[i, j];
                        num++;
                    }
                }
            }
            aver = sum / num;
            return aver;
        }
    }
}
