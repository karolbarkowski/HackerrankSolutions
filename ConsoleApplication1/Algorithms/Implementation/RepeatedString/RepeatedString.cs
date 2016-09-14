using System;
using System.IO;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\RepeatedString\\samples\\testCase1.txt"))
        {
            string s = sr.ReadLine();
            decimal n = long.Parse(sr.ReadLine());

            decimal timesSFits = Math.Floor(n / s.Length);
            decimal r = n % s.Length;

            //calculate for initial string
            decimal l1 = s.Length - s.Replace("a", "").Length;

            //calculate for remaining part of string
            string sRest = s.Substring(0, (int)r);
            decimal l2 = sRest.Length - sRest.Replace("a", "").Length;

            Console.WriteLine(l1 * timesSFits + l2);
        }
        Console.ReadLine();
    }
}