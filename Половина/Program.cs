using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Половина
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            Print(MassFill(n, array), n);
            Console.ReadLine();
        }
        static int[,] MassFill(int n, int[,] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i, n - 1 - i] = 0;
                for (int j = n - 1; j > 0; j--)
                {
                    
                    
                    array[i, j] = 3;
                    array[i, n - 1 - i] = 0;
                    if (array[i, j] == 0)
                        break;
                    else
                        array[i, j] = 1;

                }
            }
            for (int i = 0; i < n; i++)
            {
                array[i, n - 1 - i] = 0;
                for (int j = 0; j < n; j++)
                {
                    
                    array[i, j] = 3;
                    array[i, n - 1 - i] = 0;
                    if (array[i, j] == 0)
                        break;
                    else
                        array[i, j] = 2;

                }
            }
            return array;
        }
        static void Print(int[,] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
