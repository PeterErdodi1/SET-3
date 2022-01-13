using System;

namespace Problema15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N=  ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0; i<n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int k;
            for (int i = 0; i < n; i++)
            {
                
                for(int j=0; j<n-1; j++)
                {
                    if(v[i]==v[j]&&i!=j)
                    {
                        


                    }
                    if(j==n-1)
                    {
                        n--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i]);
            }

        }
    }
}
