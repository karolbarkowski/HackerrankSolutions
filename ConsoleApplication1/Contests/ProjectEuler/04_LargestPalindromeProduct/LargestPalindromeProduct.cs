using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution
{
    private static bool IsPalindrome(string s)
    {
        string sRev = new string(s.Reverse().ToArray());
        return s == sRev;
    }


    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("ProjectEuler\\04_LargestPalindromeProduct\\samples\\testCase0.txt"))
        {
            int T = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int N = Int32.Parse(sr.ReadLine());
                int max = 0;

                for (int x = 100; x <= 999; x++)
                {
                    for (int y = x; y <= 999; y++)
                    {
                        int product = x * y;
                        if (product >= N)
                            break;
                        if (product > max && IsPalindrome(product.ToString()))
                            max = product;
                    }
                }

                Console.WriteLine(max.ToString());
            }
        }

        Console.ReadLine();
    }
}