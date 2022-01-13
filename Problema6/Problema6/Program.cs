using System;

namespace Problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int k;
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if(i==k)
                {
                    while(i<n-1)
                    {
                        v[i] = v[i + 1];
                        i++;
                    }
                }
            }
            n--;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
