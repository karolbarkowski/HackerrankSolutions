using System;
using System.IO;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\TheLoveLetterMystery\\samples\\testCase0.txt"))
        {
            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int total = 0;
                string S = sr.ReadLine();
                for (int j = 0; j < Math.Floor((double)(S.Length / 2)); j++)
                {
                    char c1 = S[j];
                    char c2 = S[S.Length - j - 1];

                    total += Math.Abs(c1 - c2);
                }
                
                Console.WriteLine(total);
            }
        }
        Console.ReadLine();
    }
}


