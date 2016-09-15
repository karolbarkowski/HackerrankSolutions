using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\ServiceLane\\samples\\testCase0.txt"))
        {
            int[] nt = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int N = nt[0];
            int T = nt[1];
            int[] width = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            

            for (int t = 0; t < T; t++)
            {
                int[] ij = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
                int i = ij[0];
                int j = ij[1];

                int min = 4;
                for (int x = i; x <= j; x++)
                {
                    if (width[x] < min)
                        min = width[x];
                }

                Console.WriteLine(min);
            }
        }
        Console.ReadLine();
    }
}