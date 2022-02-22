using System;

namespace Block_4
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            var z = x;
            x = y;
            y = z;
        }
        static void QuickSort(int[] array, ref int[,] mass, int left, int right)
        {
            int l = left;
            int r = right;
            int pivot = array[(left + right) / 2];
            do
            {
                while (array[l] < pivot && l < right) l++;

                while (pivot < array[r] && r > left) r--;

                if (l <= r)
                {
                    Swap(ref array[l], ref array[r]);
                    ChangeColumns(ref mass, l, r);
                    l++;
                    r--;
                }
            } while (l <= r);

            if (left < r)
                QuickSort(array, ref mass, left, r);
            if (l < right)
                QuickSort(array, ref mass, l, right);

        }
        static int[] CountOfZerovs(int[,] array)
        {
            int[] linArr = new int[array.GetLength(1)];
            int norm;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                norm = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                   
                        norm += array[i, j];
                    
                }
                linArr[j] = norm;
            }
            return linArr;
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
            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp = array[i, x];
                array[i, x] = array[i, y];
                array[i, y] = temp;
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
        static void Main(string[] args)
        {

            string[] data = Console.ReadLine().Trim().Split();
            int n = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            int[,] mass = new int[n, m];
            MassInput(n, m, mass);
            //foreach (var item in CountOfZerovs(mass))
            //{
            //    Console.Write(item + "");
            //}
            Console.WriteLine();
            QuickSort(CountOfZerovs(mass), ref mass, 0, CountOfZerovs(mass).Length - 1);
            Print(mass);
        }
    }
}
