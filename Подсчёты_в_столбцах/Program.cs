using System;

namespace Подсчёты_в_столбцах
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = Convert.ToInt32(data[0]);//рядки
            int m = Convert.ToInt32(data[1]);//стовпці
            int[,] mass = new int[n, m];
            MassInput(n, m, mass);
            Podsch(mass);
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
        static void Podsch(int[,] arr)
        {
            
            double dis;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                double ev = 0;
                double odd = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[i, j] % 2 == 0)
                        ev += arr[i, j];
                    else 
                        odd += arr[i, j];
                }
                dis = ev - odd;
                Console.Write(Math.Abs(dis) + " ");
            }
        }
    }
}
