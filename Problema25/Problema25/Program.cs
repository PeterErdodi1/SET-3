using System;

namespace Problema25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("M= ");
            int m = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            int[] v2 = new int[m];
            int[] v3 = new int[m+n];
            for (int i=0; i<n; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < m; i++)
            {
                v2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < m; i++)
            {
                v3[i] = v2[i];
            }
            for (int i = m; i < ; i++)
            {
               
            }    
            for (int i = 0; i < m + n; i++)
            {
                Console.WriteLine(v3[i]);
            }
        }
    }
}
