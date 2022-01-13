using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problema11
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.Write("N= ");
            n=int.Parse(Console.ReadLine());
            int k=0,i;
            for (i = 1; i <= n; i++)
            {
                
                for(int j=1; j<=i; j++)
                {
                    if(i%j==0)
                    {
                        k++;
                    }
                }
                if(k==2)
                {
                    Console.WriteLine(i);
                }
                k = 0;
            }


        }
    }
}