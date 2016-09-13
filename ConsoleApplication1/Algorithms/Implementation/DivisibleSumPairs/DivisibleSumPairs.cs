using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\DivisibleSumPairs\\samples\\testCase0.txt"))
        {
            int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int k = line[1];

            int total = 0;
            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if ((arr[i] + arr[j]) % k == 0)
                        total++;
                }
            }

            Console.WriteLine(total.ToString());
        }
        Console.ReadLine();
    }
}