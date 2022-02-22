using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Минимум_по_строкам
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
            MinInRaw(array);
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

        static void MinInRaw(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int tempmax = int.MaxValue;
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] < tempmax)
                    {
                        tempmax = array[i, j];
                    }
                }
                Console.Write(tempmax + " ");

            }

            Console.ReadKey();
        }
    }
}
