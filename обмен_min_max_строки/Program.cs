using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            ChangeColumns(ref mass, Max(mass), Min(mass));
            Print(mass);
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
        static void ChangeColumns(ref int[,] array, int x, int y)
        {
            int temp;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                temp = array[x, i];
                array[x, i] = array[y, i];
                array[y, i] = temp;
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
        static int Max(int[,] mass)
        {
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] >= max)
                    {
                        max = mass[i, j];
                        index = i;
                    }
                }
            }
            return index;
        }
        static int Min(int[,] mass)
        {
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] < min)
                    {
                        min = mass[i, j];
                        index = i;
                    }
                }
            }
            return index;
        }
    }
}
