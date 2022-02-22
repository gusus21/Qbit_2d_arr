using System;

namespace Сортировка_периметра
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
            Print(Sort((2 * (n + m)) - 4 , MassToSort(n, m, arr)));
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
        static int[] MassToSort(int n, int m, int[,] arr)
        {
            int[] newArr = new int[(2 * (n + m)) - 4];
            int k = 0;
            
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (i == 0 || i == n - 1)
                        {
                            newArr[k] = arr[i, j];
                            k++;
                        }
                        
                    }
                      if (i != 0 && i != n-1)
                      {
                        newArr[k] = arr[i, 0];
                        k++;
                        newArr[k] = arr[i, m - 1];
                        k++;
                      }
                }

            return newArr;
        }
        static int[] Sort(int n, int[] arr)
        {
            int t;
            for (int i = 0; i < n - 1; ++i)

            {

                for (int j = 0; j < n - i - 1; ++j)

                {

                    if (Math.Abs(arr[j + 1]) >= Math.Abs(arr[j]))

                    {

                        t = arr[j + 1];

                        arr[j + 1] = arr[j];

                        arr[j] = t;

                    }
                    if (Math.Abs(arr[j + 1]) == Math.Abs(arr[j]) && arr[j+1] > arr[j])
                    {
                        t = arr[j + 1];

                        arr[j + 1] = arr[j];

                        arr[j] = t;
                    }
                }

            }
            return arr;
        }
        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            
        }
    }
}
