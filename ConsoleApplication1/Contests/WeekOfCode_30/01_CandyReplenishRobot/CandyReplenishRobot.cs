using System;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Contests\\WeekOfCode_30\\01_CandyReplenishRobot\\samples\\testCase1.txt"))
        {
            int[] tokens = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int n = tokens[0];
            int[] c = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int inBowl = n;
            int leftToTake = c.Sum();

            int totalReplenished = 0;
            for (int i = 0; i < c.Length; i++)
            {
                inBowl -= c[i];
                leftToTake -= c[i];

                if (inBowl < 5 && leftToTake > inBowl)
                {
                    int toReplenish = n - inBowl;
                    inBowl += toReplenish;
                    totalReplenished += toReplenish;
                }
            }

            Console.WriteLine(totalReplenished);        
        }

        Console.ReadLine();
    }
}