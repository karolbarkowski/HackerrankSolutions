using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("WorldCodeSprint7\\02_TwoCharacters\\samples\\testCase0.txt"))
        {
            sr.ReadLine();
            string s = sr.ReadLine();
            char[] dist = s.Distinct().ToArray();

            int longest = 0;
            for (int i = 0; i < dist.Length - 1; i++)
            {
                for (int j = i + 1; j < dist.Length; j++)
                {
                    char c1 = dist[i];
                    char c2 = dist[j];

                    string pattern = string.Format("{0}[^{1}]*?{2}|{3}[^{4}]*?{5}", c1, c2, c1, c2, c1, c2);
                    Regex regex = new Regex(pattern);
                    bool isMatch = regex.IsMatch(s);

                    if (!isMatch)
                    {
                        int len = s.Where(c => c == c1 || c == c2).Count();
                        if (len > longest)
                            longest = len;
                    }
                }
            }

            Console.WriteLine(longest);
        }

        Console.ReadLine();
    }
}