using System;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int min = 2147483647;
            int max = -2147483648;
            int a=0, b=0;
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0; i<n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if(v[i]==max)
                {
                    a++;
                }
                else if(v[i]==min)
                {
                    b++;
                }
                if(v[i]>max)
                {
                    max = v[i];
                    a = 1;
                }
                if (v[i] < min)
                {
                    min = v[i];
                    b = 1;
                }

            }
            Console.WriteLine(a + " " + b);
            
            
        }
    }
}
