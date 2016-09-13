using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution
{
    private static BigInteger factorial(BigInteger N)
    {
        if (N == 0 || N == 1)
            return 1;

        return N * factorial(N - 1);
    }

    static void Main(String[] args)
    {
        int N = Convert.ToInt32("25");
        BigInteger f = factorial(N);

        Console.WriteLine(f.ToString());
        Console.ReadLine();
    }
}