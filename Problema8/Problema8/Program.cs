using System;

namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=  ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0; i<n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int r;
            
            Console.WriteLine(v[n-1]);
            for (int i =(n-1); i>0; i--)
            {
                r = v[i];
                v[i] = v[i-1];
                v[i - 1] = r;
                
                


            }
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Rotit> "+ v[i]);
            }
        }
    }
}
