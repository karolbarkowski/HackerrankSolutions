using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("30DaysOfCode\\10_BinaryNumbers\\samples\\testCase0.txt"))
        {
            int n = int.Parse(sr.ReadLine());
            string binary = Convert.ToString(n, 2);

            Regex pattern = new Regex("([1]*)");
            MatchCollection m = pattern.Matches(binary);
            int max = m.Cast<Match>().Max(x => x.Length);

            Console.WriteLine(max.ToString());
        }

        Console.ReadLine();
    }
}