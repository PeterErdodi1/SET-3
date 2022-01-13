using System;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int n = int.Parse(Console.ReadLine());
            int[] v= new int[n];
            for(int i=0; i<n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int e, k;
            Console.WriteLine("E= ");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("K= ");
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if(i==e)
                {
                    v[i] = k;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i]);
            }

        }
    }
}
