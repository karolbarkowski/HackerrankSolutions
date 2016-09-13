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
        using (StreamReader sr = new StreamReader("30DaysOfCode\\08_DictionariesAndMaps\\samples\\testCase0.txt"))
        {
            int T = Convert.ToInt32(sr.ReadLine());
            Dictionary<string, string> pb = new Dictionary<string, string>();

            for (int i = 0; i < T; i++)
            {
                string[] line = sr.ReadLine().Split(new char[] { ' ' });
                pb.Add(line[0], line[1]);
            }

            for (int i = 0; i < T; i++)
            {
                string line = sr.ReadLine();
                if (pb.ContainsKey(line))
                    Console.WriteLine(string.Format("{0}={1}", line, pb[line]));
                else
                    Console.WriteLine("Not found");
            }
        }

        Console.ReadLine();
    }
}