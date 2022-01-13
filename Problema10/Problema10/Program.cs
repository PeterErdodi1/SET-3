using System;

namespace Problema10
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
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("k= ");
            int k= int.Parse(Console.ReadLine());
            bool ok = false;
            for(int i=0; i<n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine("Pozitia elementului k> " + i);
                    ok = false;
                    break;
                }
                else
                {
                    ok = true;
                }
            }
            if(ok)
            {
                Console.WriteLine("-1");
            }
        }
    }
}
