using System;
using System.IO;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\SuperReducedString\\samples\\testCase1.txt"))
        {
            string s = sr.ReadLine();
            string exp = @"a{2}|b{2}|c{2}|d{2}|e{2}|f{2}|g{2}|h{2}|i{2}|j{2}|k{2}|l{2}|m{2}|n{2}|o{2}|p{2}|q{2}|r{2}|s{2}|t{2}|u{2}|v{2}|w{2}|x{2}|y{2}|z{2}";

            int beforeLength = 0, afterLength = 0;
            do
            {
                beforeLength = s.Length;
                s = Regex.Replace(s, exp, "");
                afterLength = s.Length;
            }
            while (beforeLength != afterLength);

            Console.WriteLine(s.Length > 0 ? s : "Empty String");
        }
        Console.ReadLine();
    }
}


