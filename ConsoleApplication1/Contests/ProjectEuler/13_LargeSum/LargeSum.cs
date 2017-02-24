using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("ProjectEuler\\13_LargeSum\\samples\\testCase0.txt"))
        {
            int N = Convert.ToInt32(sr.ReadLine());
            BigInteger sum = new BigInteger();

            for (int i = 0; i < N; i++)
            {
                BigInteger n = BigInteger.Parse(sr.ReadLine());
                sum += n;
            }
            Console.WriteLine(sum.ToString().Substring(0, 10));
        }

        Console.ReadLine();
    }
}