using System;
using System.Linq;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Warmup\\BirthdayCakeCandle\\samples\\testCase0.txt"))
        {
            sr.ReadLine();
            int[] heights = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int currentMax = -1;
            int count = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] > currentMax)
                {
                    currentMax = heights[i];
                    count = 1;
                }
                else if (heights[i] == currentMax)
                    count++;
            }

            Console.WriteLine(count);
        }
        Console.ReadLine();
    }
}


