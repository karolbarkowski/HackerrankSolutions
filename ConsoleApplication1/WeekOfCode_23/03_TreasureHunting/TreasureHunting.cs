using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("WeekOfCode_23\\03_TreasureHunting\\samples\\testCase0.txt"))
        {
            int[] xy = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int[] ab = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);

            double x = xy[0];
            double y = xy[1];
            double a = ab[0];
            double b = ab[1];
            double a1 = -b;
            double b1 = a;

            double n = (x * b - y * a) / (a1 * b - b1 * a);
            double k = (x - n * a1) / a;

            Console.WriteLine(k.ToString("0.000000000000"));
            Console.WriteLine(n.ToString("0.000000000000"));
        }

        Console.ReadLine();
    }
}