using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\CutTheSticks\\samples\\testCase0.txt"))
        {
            sr.ReadLine();
            int[] sticks = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);

            int count = sticks.Where(c => c > 0).Count();

            do
            {
                Console.WriteLine(count);

                int min = sticks.Where(c => c > 0).Min();
                for (int i = 0; i < sticks.Length; i++)
                {
                    sticks[i] = Math.Max(0, sticks[i] - min);
                }

                count = sticks.Where(c => c > 0).Count();
            }
            while (count > 0);

        }
        Console.ReadLine();
    }
}