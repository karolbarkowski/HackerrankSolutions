using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\BreakingTheRecords\\samples\\testCase1.txt"))
        {
            sr.ReadLine();
            int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);

            int least = line[0];
            int most = line[0];
            int leastBreaks = 0;
            int mostBreaks = 0;

            for (int i = 1; i < line.Length; i++)
            {
                if (line[i] < least)
                {
                    leastBreaks++;
                    least = line[i];
                }
                else if (line[i] > most)
                {
                    mostBreaks++;
                    most = line[i];
                }
            }

            Console.WriteLine(string.Format("{0} {1}", mostBreaks, leastBreaks));
        }
        Console.ReadLine();
    }
}