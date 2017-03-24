using System;
using System.Linq;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Warmup\\MiniMaxSum\\samples\\testCase0.txt"))
        {
            Int64[] n = Array.ConvertAll(sr.ReadLine().Split(' '), Int64.Parse);
            Int64 nMax = n.Max();
            Int64 nMin = n.Min();
            Int64 sum = n.Sum();

            Console.WriteLine(string.Format("{0} {1}", sum - nMax, sum - nMin));
        }
        Console.ReadLine();
    }
}


