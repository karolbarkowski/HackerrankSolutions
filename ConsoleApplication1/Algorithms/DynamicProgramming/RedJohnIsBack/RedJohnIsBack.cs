using System;
using System.IO;
using System.Linq;

class Solution
{
    private static int CalculateCombinations(int N)
    {
        if (N < 4)
            return 1;

        int vBricks = N % 4;
        int n = 0;
        while (vBricks < N)
        {
            n += vBricks + 1;
            vBricks += 4;
        }
        n++;    //add last case where all bricks are vertical

        return n;
    }

    private static int CountPrimes(int N)
    {
        int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191 };
        return primes.Where(p => p <= N).Count();
    }

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\DynamicProgramming\\RedJohnIsBack\\samples\\testCase0.txt"))
        {
            int T = Int32.Parse(sr.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = Int32.Parse(sr.ReadLine());
                int com = CalculateCombinations(N);
                int p = CountPrimes(com);

                Console.WriteLine(p);
            }
        }
        Console.ReadLine();
    }
}