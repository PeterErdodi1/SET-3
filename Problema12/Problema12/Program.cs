using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[15] { 45, 72, 58, 92, 26, 4, 13, 90, 81, 15, 33, 36, 47, 8, 54 };
            int n = 15;
            Console.WriteLine("Selection Sort");
            int k, b;
            for (int i = 0; i < n - 1; i++)
            {
                
                b = i;
                
                for (int j = i + 1; j < n; j++)
                {
                    
                    if (v[j] < v[b])
                    {
                        b = j;
                    }
                }
                
                k = v[b];
                v[b] = v[i];
                v[i] = k;
            }

            for(int i=0; i<n; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
