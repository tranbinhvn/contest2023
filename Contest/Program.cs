using System;
using System.Collections.Generic;
using System.Linq;

namespace contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int n = int.Parse(Console.ReadLine());
            long standingCount = (long)Math.Sqrt(n);
            Console.WriteLine("Count Sqrt: " + standingCount);

            Console.WriteLine("Count while: " + CountStand(n));
        }
        static int CountStand(long n)
        {
            if (n < 1) return 0;
            if (n < 4) return 1;
            int num = 1;
            int start = 1;
            while (n > start)
            {
                start = start + 2;
                n = n - start;
                if (n > 0) num++;
            }
            return num;
        }
    }
}
