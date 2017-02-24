using System;
using System.IO;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\BeautifulBinaryString\\samples\\testCase0.txt"))
        {
            sr.ReadLine();
            string S = sr.ReadLine();

            Regex regex = new Regex("010");
            var matches = regex.Matches(S);

            Console.WriteLine(matches.Count);
        }
        Console.ReadLine();
    }
}


