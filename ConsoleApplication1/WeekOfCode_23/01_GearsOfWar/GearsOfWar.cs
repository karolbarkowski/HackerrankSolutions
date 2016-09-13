using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("WeekOfCode_23\\01_GearsOfWar\\samples\\testCase0.txt"))
        {
            int T = Convert.ToInt32(sr.ReadLine());
            Regex pattern = new Regex(@"^\d*[02468]$");

            for (int i = 0; i < T; i++)
            {
                Console.WriteLine(pattern.IsMatch(sr.ReadLine()) ? "Yes" : "No");
            }
        }

        Console.ReadLine();
    }
}