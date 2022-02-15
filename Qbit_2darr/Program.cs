using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_po_stolbtsam
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
            Maxstolb(n, m, array);
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

        static void Maxstolb(int n, int m, int[,] array)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int tempmax = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    
                    if (array[i, j] > tempmax)
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
