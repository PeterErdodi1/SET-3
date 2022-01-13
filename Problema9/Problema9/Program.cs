using System;

namespace Problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=  ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int r;
            Console.WriteLine("k=  ");
            int k= int.Parse(Console.ReadLine());

            for (int j = 0; j < k; j++)
            {
                for (int i = (n - 1); i > 0; i--)
                {

                    r = v[i];
                    v[i] = v[i - 1];
                    v[i - 1] = r;




                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rotit> " + v[i]);
            }
        }
    }
}
