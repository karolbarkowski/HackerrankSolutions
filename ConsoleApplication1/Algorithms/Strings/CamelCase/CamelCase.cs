using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\CamelCase\\samples\\testCase0.txt"))
        {
            string s = sr.ReadLine();
            int counter = 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i])) counter++;
            }

            Console.WriteLine(counter.ToString());
        }
        Console.ReadLine();
    }
}