using System;
using System.IO;
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
        using (StreamReader sr = new StreamReader("30DaysOfCode\\09_Recursion\\samples\\testCase0.txt"))
        {
            BigInteger n = BigInteger.Parse(sr.ReadLine());
            Console.WriteLine(factorial(n).ToString());
        }

        Console.ReadLine();
    }
}