using System;
using System.IO;
namespace Probelma1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int m = 0;
            int n = int.Parse(Console.ReadLine());
            
            int[] v = new int [n];
            Console.WriteLine(n);
            for(int i=0; i<v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < v.Length; i++)
            {
                m = v[i] + m;
            }
            Console.WriteLine(m);
        }
    }
}
