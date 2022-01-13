using System;

namespace Problema14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0; i<n; i++)
            {
                v[i]= int.Parse(Console.ReadLine());
            }
            int k;
            for(int i=0; i<n-1; i++)
            {
                
                if(v[i]==0)
                {
                    for(int j=i; j<n-1; j++)
                    {
                        k = v[j + 1];
                        v[j + 1] = v[j];
                        v[j] = k;

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
