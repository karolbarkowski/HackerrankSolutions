using System;
using System.IO;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\Pangrams\\samples\\testCase0.txt"))
        {
            string s = sr.ReadLine();

            Regex regex = new Regex(@"(?=.*a)(?=.*b)(?=.*c)(?=.*d)(?=.*e)(?=.*f)(?=.*g)(?=.*h)(?=.*i)(?=.*j)(?=.*k)(?=.*l)(?=.*m)(?=.*n)(?=.*o)(?=.*p)(?=.*q)(?=.*r)(?=.*s)(?=.*t)(?=.*u)(?=.*v)(?=.*w)(?=.*x)(?=.*y)(?=.*z)", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(s);

            Console.WriteLine(matches.Count > 0 ? "pangram" : "not pangram");
        }
        Console.ReadLine();
    }
}


