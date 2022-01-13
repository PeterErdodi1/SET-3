using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0; i<n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            int k = int.Parse(Console.ReadLine());
            int a;
            a = 0;
            for(int i=0; i<n; i++)
            {
                if(k!=v[i])
                {
                    a = -1;
                    
                }
                else
                {
                    Console.WriteLine(i);
                    a = 0;
                    break;
                }
            }
            if(a==-1)
            {
                Console.WriteLine(a);
            }
        }
    }
}
