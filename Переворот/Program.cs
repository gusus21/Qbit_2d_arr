using System;

namespace Переворот
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = Convert.ToInt32(data[0]);//рядки
            int m = Convert.ToInt32(data[1]);//стовпці
            int[,] matr = new int[n, m];
            Random ran = new Random();

            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Trim().Split();
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = Convert.ToInt32(numbers[j]);
                }
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //        Console.Write(matr[i, j] + " ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            Console.WriteLine(matr.GetLength(1) + " " + matr.GetLength(0));
            for (int j = 0; j < m; j++)
            {
                for (int i = n - 1; i >= 0; i--)

                    Console.Write(matr[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
