using System;
using System.Collections.Generic;
using System.Linq;

namespace contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B3();
            //int T = int.Parse(Console.ReadLine());
            //List<string> L1 = new List<string>();
            //List<string> L2 = new List<string>();
            //for (int i = 0; i < T; i++)
            //{
            //    L1.Add(Console.ReadLine());
            //    L2.Add(Console.ReadLine());
            //}
            //for (int i = 0; i < T; i++)
            //{
            //    char[] s1 = L1[i].ToCharArray();
            //    char[] s2 = L2[i].ToCharArray();                
            //    Console.WriteLine(B4_Process(s1, s2));
            //}
        }

        static void B3()
        {
            var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(" "), int.Parse);
            int N = arr[0]; // May
            int M = arr[1]; // Day mang
            HashSet<int> uList = new HashSet<int>();
            for (int i = 0; i < M; i++)
            {
                var temp = Array.ConvertAll(Console.ReadLine().Trim().Split(" "), int.Parse);
                uList.Add(temp[0]);
                uList.Add(temp[1]);
            }
            if (M >= N-1)
            {
                if (uList.Count >= N)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(N - uList.Count);
                }
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        static string B4_Process(char[] s1, char[] s2)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;
            char[] result = new char[len1 + len2];
            int i = 0;
            int j = 0;
            for (int s = 0; s < result.Length; s++)
            {
                if (i < len1 && j < len2)
                {
                    if (s1[i] < s2[j])
                    {
                        result[s] = s1[i];
                        i++;
                    }
                    else
                    {
                        result[s] = s2[j];
                        j++;
                    }
                }
                else
                {
                    if (i < len1)
                    {
                        result[s] = s1[i];
                        i++;
                    }
                    else
                    {
                        result[s] = s2[j];
                        j++;
                    }
                }
            }
            return new string(result);
        }
    }
}
