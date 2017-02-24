using System;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\AlternatingCharacters\\samples\\testCase0.txt"))
        {
            int N = int.Parse(sr.ReadLine());
            
            for (int i = 0; i < N; i++)
            {
                int deletions = 0;
                string S = sr.ReadLine();
                for (int j = 0; j < S.Length - 1; j++)
                {
                    if (S[j] == S[j + 1]) deletions++;
                }

                Console.WriteLine(deletions);
            }

        }
        Console.ReadLine();
    }
}


