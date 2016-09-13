using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution
{
    private static long GCD(long x, long y)
    {
        return y == 0 ? x : GCD(y, x % y);
    }

    private static long LCM(long x, long y)
    {
        return x * y / GCD(x, y);
    }

    private static long LCMMulti(int N)
    {
        if (N == 1)
            return 1;

        if (N == 2)
            return LCM(1, 2);

        return LCM(N, LCMMulti(N - 1));
    }

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("ProjectEuler\\05_SmallestMultiple\\samples\\testCase0.txt"))
        {
            int T = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int N = Int32.Parse(sr.ReadLine());
                Console.WriteLine(LCMMulti(N).ToString());
            }
        }

        Console.ReadLine();
    }
}