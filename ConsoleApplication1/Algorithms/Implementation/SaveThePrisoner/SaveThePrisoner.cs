using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\SaveThePrisoner\\samples\\testCase0.txt"))
        {
            int T = Convert.ToInt32(sr.ReadLine());
            for (int t = 0; t < T; t++)
            {
                int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
                int N = line[0];
                int M = line[1];
                int S = line[2];

                int result = (S + M - 1) % N;
                Console.WriteLine(result > 0 ? result : N);
            }            
        }
    }
}