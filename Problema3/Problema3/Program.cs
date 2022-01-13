using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("N = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            int min, max;
            min = v[0];
            max = v[0];

            for (i = 0; i < n; i++)
            {
                if (v[i] >= max)
                {
                    max = v[i];
                }
                if (min >= v[i])
                {
                    min = v[i];
                }
            }
            for (i = 0; i < n; i++)
            {
                if (v[i] == max)
                {
                    Console.WriteLine("Poz. Max= " + i);
                }

            }

            for (i = 0; i < n; i++)
            {
                if (v[i] == min)
                {
                    Console.WriteLine("Poz. Max= " + i);
                }

            }

        }
    }
}

