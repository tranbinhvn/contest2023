using System;
using System.Collections.Generic;
using System.Linq;

namespace contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B1();
            //B2();
            //B3();
            //B4();
            //B5();
        }

        #region B1
        public static void B1()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            int result = 0;
            int current = arr[0];
            for (int i = 0; i < n - 1; i++)
            {
                if (current < arr[i]) continue;
                current = arr[i];
                int[] tempArr = new int[n - i - 1];
                Array.Copy(arr, i + 1, tempArr, 0, (n - i - 1));

                var maxSub = tempArr.Max();
                if ((maxSub - current) > result) result = maxSub - current;

            }
            Console.WriteLine(result);
        }

        public static int B1_Process(int[] arr)
        {
            int n = arr.Length;
            if (n == 1) return 0;
            int result = 0;
            int current = arr[0];
            for (int i = 0; i < n - 1; i++)
            {
                if (current < arr[i]) continue;
                current = arr[i];
                int[] tempArr = new int[n - i - 1];
                Array.Copy(arr, i + 1, tempArr, 0, (n - i - 1));

                var maxSub = tempArr.Max();

                if (current < maxSub)
                {
                    if ((maxSub - current) > result) result = maxSub - current;
                }

            }
            return result;
        }

        #endregion B1

    }
}
