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
        using (StreamReader sr = new StreamReader("Mathematics\\Fundamentals\\MaximumDraws\\samples\\testCase0.txt"))
        {
            int N = Int32.Parse(sr.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int p = Int32.Parse(sr.ReadLine());
                Console.WriteLine(p == 1 ? "2" : (p + 1).ToString());
            }
        }

        Console.ReadLine();
    }
}