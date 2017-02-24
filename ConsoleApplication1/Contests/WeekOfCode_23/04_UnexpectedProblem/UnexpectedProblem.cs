using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(string[] args)
    {
        using (StreamReader sr = new StreamReader("WeekOfCode_23\\04_UnexpectedProblem\\samples\\testCase0.txt"))
        {
            string s = sr.ReadLine();
            int m = int.Parse(sr.ReadLine());

            int found = 0;
            for (int i = 1; i <= s.Length; i++)
            {
                string sSub = s.Substring(0, i);

                Regex match = new Regex(string.Format("^({0})*$", sSub));
                bool isOk = match.IsMatch(s);
                if (!isOk)
                    continue;

                found += m / sSub.Length;
                break;
            }

            Console.WriteLine(found);
        }

        Console.ReadLine();
    }
}