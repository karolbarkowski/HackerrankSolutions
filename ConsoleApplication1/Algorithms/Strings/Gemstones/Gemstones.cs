using System;
using System.Collections;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\Gemstones\\samples\\testCase0.txt"))
        {
            int N = int.Parse(sr.ReadLine());
            Hashtable gems = new Hashtable();

            //read first line
            string firstLine = sr.ReadLine();
            foreach (char c in firstLine)
            {
                gems[c] = true;
            }

            //read remaining lines
            for (int i = 0; i < N - 1; i++)
            {
                string S = sr.ReadLine();
                foreach (char c in firstLine)
                {
                    if (!S.Contains(c.ToString()))
                    {
                        gems.Remove(c);
                    }
                }
            }

            Console.WriteLine(gems.Count);
        }
        Console.ReadLine();
    }
}


