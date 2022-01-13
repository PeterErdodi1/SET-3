using System;

namespace Problema17
{
    class Program
    {
        static void binary(string n)
        {
            string r;
            int k = Convert.ToInt32(n);
            r = "";
            while (k > 1)
            {
                int a = k % 2;
                r = Convert.ToString(a) + r;
                k /= 2;
            }
            r = Convert.ToString(k) + r;
            Console.WriteLine("Binary: {0}", r);
        }
        static void hexa(string n)
        {
            string r;
            int k = Convert.ToInt32(n);
            r = "";
            while (k > 5)
            {
                int a = k % 6;
                r = Convert.ToString(a) + r;
                k /= 6;
            }
            r = Convert.ToString(k) + r;
            Console.WriteLine("Hexa: {0}", r);
        }
        static void oct(string n)
        {
            string r;
            int k = Convert.ToInt32(n);
            r = "";
            while (k > 7)
            {
                int a = k % 8;
                r = Convert.ToString(a) + r;
                k /= 8;
            }
            r = Convert.ToString(k) + r;
            Console.WriteLine("Hexa: {0}", r);
        }

        static void Main(string[] args)
        {
            string n;
            Console.Write("N=   ");
            n = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());
            if(m==2)
            { 
                binary(n);
            }
            if(m==6)
            {
                hexa(n);
            }
            if(m==8)
            {
                oct(n);
            }
            
        }
    }
}
