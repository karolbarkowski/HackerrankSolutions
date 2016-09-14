using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    //private static int nwd(int a, int b)
    //{
    //    int x = a, y = b;
    //    while (x != y)
    //    {
    //        if (x > y)
    //            x = x - y;
    //        else
    //            y = y - x;
    //    }
    //    return x;
    //}

    //private static int nww(int a, int b)
    //{
    //    return a * b / nwd(a, b);
    //}

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\Kangaroo\\samples\\testCase22.txt"))
        {
            int[] tokens_x1 = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            double x1 = tokens_x1[0];
            double v1 = tokens_x1[1];
            double x2 = tokens_x1[2];
            double v2 = tokens_x1[3];

            if (v1 == v2 || (x1 < x2 && v1 < v2) || (x1 > x2 && v1 > v2) || (x1 == x2 && v1 != v2))
                Console.WriteLine("NO");
            else
            {
                double n = (x1 - x2) / (v2 - v1);
                bool isPositiveInt = n > 0 && n % 1 == 0;
                Console.WriteLine(isPositiveInt ? "YES" : "NO");
            }
        }
        Console.ReadLine();
    }
}