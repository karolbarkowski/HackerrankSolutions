using System;
using System.IO;
using System.Text.RegularExpressions;

class Solution
{
    //private static long CalculateArithmeticProgression(int a1, int an, int n)
    //{
    //    if (an == 0)
    //        return 1;

    //    //a1 - first element in progression
    //    //an - last element in progression
    //    //n - number of elements to sum

    //    //S = ½(a1 + an)n
    //    return ((a1 + an) * n) / 2;
    //}

    private static long CalculateArithmeticProgression(int a1, int d, int n)
    {
        //½(2a1 + d(n-1))n
        return (((2 * a1) + (d * (n - 1))) * n) / 2;
    }

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("ProjectEuler\\01_MultiplesOf3And5\\samples\\testCase1.txt"))
        {
            int T = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < T; i++)
            {
                decimal N = decimal.Parse(sr.ReadLine());

                int n3 = (int)(Math.Floor((N - 1) / 3));
                int n5 = (int)(Math.Floor((N - 1) / 5));
                int n15 = (int)(Math.Floor((N - 1) / 15));
              //  int last3 = 3 + ((n3 - 1) * 3);
              //  int last5 = 5 + ((n5 - 1) * 5); ;
             //   int last15 = 15 + ((n15 - 1) * 5);

                long sum3 = N >= 3 ? CalculateArithmeticProgression(3, 3, n3) : 0;
                long sum5 = N >= 5 ? CalculateArithmeticProgression(5, 5, n5) : 0;
                long sum15 = N >= 15 ? CalculateArithmeticProgression(15, 15, n15) : 0;

                long sum = sum3 + sum5 - sum15;
                Console.WriteLine(sum.ToString());
            }
        }

        Console.ReadLine();
    }
}