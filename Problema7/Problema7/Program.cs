using System;

namespace Problema7
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
            for (int i =0 ; i < (n/2); i++)
            {
                r = v[i];
                
               
                    
              
               
               
                    v[i] = v[n - i- 1];
                    v[n - i-1] = r;
               
                
            }
            Console.WriteLine("REV>  ");
            for (int i=0; i<n; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
