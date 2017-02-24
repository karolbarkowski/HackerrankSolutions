using System;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\MarsExploration\\samples\\testCase9.txt"))
        {
            string s = sr.ReadLine();

            int count = 0;
            for (int i = 0; i < s.Length; i += 3)
            {
                if (s[i] != 'S') count++;
                if (s[i + 1] != 'O') count++;
                if (s[i + 2] != 'S') count++;
            }

            Console.WriteLine(count);
        }
        Console.ReadLine();
    }
}


