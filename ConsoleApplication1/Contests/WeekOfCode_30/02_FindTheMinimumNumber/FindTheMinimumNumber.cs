using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

class Solution
{

    private static string GetMin(int n)
    {
        if (n == 2)
            return "min(int, int)";
        else
            return string.Format("min(int, {0})", GetMin(n - 1));
    }

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Contests\\WeekOfCode_30\\02_FindTheMinimumNumber\\samples\\testCase2.txt"))
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetMin(n));
        }

        Console.ReadLine();
    }
}