using System;

namespace Problema13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10]
            {
                1, 5, 4, 11, 20, 8, 2, 98, 90, 16
            };

            InsertionSort(v);
            Console.WriteLine("Sorted Values:");
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine(v[i]);

            
            static void InsertionSort(int[] v)
            {
                int j, k;
                for (int i = 1; i <= v.Length - 1; i++)
                {
                    k = v[i];
                    j = i - 1;
                    while (j >= 0 && v[j] > k)
                    {
                        v[j + 1] = v[j];
                        j--;
                    }
                    v[j + 1] = k;
                }
            }
        }
    }
}
