using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution
{
    private static ulong SumOfSquares(int N)
    {
        ulong sum = (ulong)((N * (N + 1) * (2 * N + 1)) / 6);
        return sum;
    }

    private static ulong SquareOfSum(int N)
    {
        ulong sum = (ulong)((N * (N + 1)) / 2);
        return sum * sum;
    }

    private static ulong SumOfSquares2(int N)
    {
        ulong sum = new ulong();
        for (int i = 1; i <= N; i++)
        {
            sum += (ulong)(i * i);
        }
        return sum;
    }

    private static ulong SquareOfSum2(int N)
    {
        ulong sum = new ulong();
        for (int i = 1; i <= N; i++)
        {
            sum += (ulong)i;
        }
        return sum * sum;
    }

    static void Main(String[] args)
    {
            Console.WriteLine(SumOfSquares(1000).ToString() + " - " + SumOfSquares2(1000).ToString());
            Console.WriteLine(SquareOfSum(10000).ToString() + " - " + SquareOfSum2(10000).ToString());
            Console.WriteLine("");

        //using (StreamReader sr = new StreamReader("ProjectEuler\\06_SumSquareDifference\\samples\\testCase0.txt"))
        //{
        //    int T = Convert.ToInt32(sr.ReadLine());
        //    for (int i = 0; i < T; i++) {
        //        int N = Int32.Parse(sr.ReadLine());

        //        ulong sumOfSquares = SumOfSquares(N);
        //        ulong squareOfSum = SquareOfSum(N);

        //        Console.WriteLine(sumOfSquares.ToString());
        //        Console.WriteLine(squareOfSum.ToString());

        //        //ulong result;
        //        //if (sumOfSquares >= squareOfSum)
        //        //    result = sumOfSquares - squareOfSum;
        //        //else
        //        //    result = squareOfSum - sumOfSquares;
        //        //Console.WriteLine(result.ToString());
        //    }
        //}

        Console.ReadLine();
    }
}