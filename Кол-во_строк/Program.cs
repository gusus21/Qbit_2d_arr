using System;

namespace Кол_во_строк
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            int[,] arr = new int[n, m];
            MassInput(arr);
            EvenAndOdd(arr);
            NumOfRaw(arr);
        }
        static int[,] MassInput(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string[] numbers = Console.ReadLine().Trim().Split();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(numbers[j]);
                }
            }
            return array;
        }

        static void EvenAndOdd(int[,] array)
        {
            int allEv = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int ev = 0;
                int odd = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (Math.Abs(array[i, j]) % 2 == 0)
                        ev++;
                    else
                        odd++;
                }
                if (ev > odd)
                {
                    allEv++;
                }
            }
            Console.WriteLine(allEv);
        }
        static void NumOfRaw(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int ev = 0;
                int odd = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (Math.Abs(array[i, j]) % 2 == 0)
                        ev++;
                    else
                        odd++;
                }
                if (ev > odd)
                {
                    Console.Write(i + 1 + " ");
                }
            }
        }
    }
}
