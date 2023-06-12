using System;
using System.Collections.Generic;
using System.Linq;

namespace contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            List<string> L1 = new List<string>();
            List<string> L2 = new List<string>();
            for (int i = 0; i < T; i++)
            {
                L1.Add(Console.ReadLine());
                L2.Add(Console.ReadLine());
            }
            for (int i = 0; i < T; i++)
            {
                char[] s1 = L1[i].ToCharArray();
                char[] s2 = L2[i].ToCharArray();                
                Console.WriteLine(B4_Process(s1, s2));
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
