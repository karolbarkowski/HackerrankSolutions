using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        //Utopian Identification Number
        //using (StreamReader sr = new StreamReader("Regex\\samples\\UtopianIdentificationNumber_TestCase0.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());
        //    for (int i = 0; i < N; i++)
        //    {
        //        Regex pattern = new Regex(@"^[a-z]{0,3}[0-9]{2,8}[A-Z]{3,}$");
        //        Console.WriteLine(pattern.IsMatch(sr.ReadLine()) ? "VALID" : "INVALID");
        //    }

        //    Console.ReadLine();
        //}

        //Alien Username
        //using (StreamReader sr = new StreamReader("Regex\\samples\\AlienUsername_TestCase10.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());            
        //    for (int i = 0; i < N; i++)
        //    {
        //        Regex pattern = new Regex(@"^[_\.][0-9]+[a-zA-Z]*_?$");
        //        Console.WriteLine(pattern.IsMatch(sr.ReadLine()) ? "VALID" : "INVALID");
        //    }

        //    Console.ReadLine();
        //}

        //HackerRank Tweets
        //using (StreamReader sr = new StreamReader("Regex\\samples\\HackerRankTweets_TestCase0.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < N; i++)
        //    {
        //        sb.Append(" ").Append(sr.ReadLine());
        //    }

        //    Regex pattern = new Regex(@"\b[#@]*hackerrank\b", RegexOptions.IgnoreCase);
        //    int matches = pattern.Matches(sb.ToString()).Count;
        //    Console.WriteLine(matches.ToString());

        //    Console.ReadLine();
        //}

        //HackerRank Language
        //using (StreamReader sr = new StreamReader("Regex\\samples\\HackerRankLanguage_TestCase0.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());

        //    for (int i = 0; i < N; i++)
        //    {
        //        Regex pattern = new Regex(@"^\d* (C|CPP|JAVA|PYTHON|PERL|PHP|RUBY|CSHARP|HASKELL|CLOJURE|BASH|SCALA|ERLANG|CLISP|LUA|BRAINFUCK|JAVASCRIPT|GO|D|OCAML|R|PASCAL|SBCL|DART|GROOVY|OBJECTIVEC)$");
        //        Console.WriteLine(pattern.IsMatch(sr.ReadLine()) ? "VALID" : "INVALID");
        //    }

        //    Console.ReadLine();
        //}

        //The British and American Style of Spelling
        //using (StreamReader sr = new StreamReader("Regex\\samples\\BritishAndAmericanStyleOfSpeccing_TestCase7.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < N; i++)
        //    {
        //        sb.Append(" ").Append(sr.ReadLine());
        //    }
        //    string text = sb.ToString();

        //    var T = Int32.Parse(sr.ReadLine());
        //    for (int i = 0; i < T; i++)
        //    {
        //        string word = sr.ReadLine();
        //        string regex = string.Format(@"\b{0}(ze|se)\b", word.Substring(0, word.Length - 2));
        //        Regex pattern = new Regex(regex);
        //        MatchCollection matches = pattern.Matches(text);

        //        Console.WriteLine(matches.Count.ToString());
        //    }

        //    Console.ReadLine();
        //}

        //Find Hackerank
        //using (StreamReader sr = new StreamReader("Regex\\samples\\FindHackerrank_TestCase0.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());
        //    Regex pattern1 = new Regex(@"^hackerrank");
        //    Regex pattern2 = new Regex(@"hackerrank$");

        //    for (int i = 0; i < N; i++)
        //    {
        //        string line = sr.ReadLine();
        //        bool match1 = pattern1.IsMatch(line);
        //        bool match2 = pattern2.IsMatch(line);

        //        if (match1 && match2)
        //            Console.WriteLine("0");
        //        else if (match1)
        //            Console.WriteLine("1");
        //        else if (match2)
        //            Console.WriteLine("2");
        //        else
        //            Console.WriteLine("-1");
        //    }

        //    Console.ReadLine();
        //}

        //Detecting Valid Latitude and Longitude Pairs
        //using (StreamReader sr = new StreamReader("Regex\\samples\\DetectingValidLatitudeAndLongitude_TestCase2.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());
        //    Regex pattern = new Regex(@"\([+-]?(90(\.\d+)*|[0-8][0-9](\.\d+)*|[0-9](\.\d+)*), [+-0]?(180(\.0+)*|1[0-7][0-9](\.\d+)*|[0-9][0-9](\.\d+)*)\)");

        //    for (int i = 0; i < N; i++)
        //    {
        //        Console.WriteLine(pattern.IsMatch(sr.ReadLine()) ? "Valid" : "Invalid");
        //    }

        //    Console.ReadLine();
        //}

        //Split the phone numbers
        //using (StreamReader sr = new StreamReader("Regex\\samples\\SplitThePhoneNumbers_Sample1.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());
        //    Regex pattern = new Regex(@"(\d{1,3})[- ]{1}(\d{1,3})[- ]{1}(\d{4,10})");

        //    for (int i = 0; i < N; i++)
        //    {
        //        Match match = pattern.Match(sr.ReadLine());
        //        Console.WriteLine(string.Format("CountryCode={0},LocalAreaCode={1},Number={2}", match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value));
        //    }

        //    Console.ReadLine();
        //}

        //Valid PAN format
        //using (StreamReader sr = new StreamReader("Regex\\samples\\ValidPANFormat_Sample1.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());
        //    Regex pattern = new Regex(@"^[A-Z]{5}[0-9]{4}[A-Z]{1}$");

        //    for (int i = 0; i < N; i++)
        //    {
        //        Console.WriteLine(pattern.IsMatch(sr.ReadLine()) ? "YES" : "NO");
        //    }

        //    Console.ReadLine();
        //}

        //Detect HTML tags
        //using (StreamReader sr = new StreamReader("Regex\\samples\\DetectHtmlTags_Sample1.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());
        //    string doc = sr.ReadToEnd();
        //    Regex pattern = new Regex(@"<\s*([a-zA-Z0-9]+).*?>", RegexOptions.IgnoreCase);
        //    MatchCollection matches = pattern.Matches(doc);

        //    HashSet<string> result = new HashSet<string>();
        //    foreach (Match m in matches)
        //    {
        //        if (!result.Contains(m.Groups[1].Value))
        //            result.Add(m.Groups[1].Value);
        //    }

        //    Console.WriteLine(string.Join(";", result.OrderBy(s => s)));
        //    Console.ReadLine();
        //}

        //Detect HTML Links
        //using (StreamReader sr = new StreamReader("Regex\\samples\\DetectHtmlLinks_TestCase5.txt"))
        //{
        //    var N = Int32.Parse(sr.ReadLine());
        //    string doc = sr.ReadToEnd();
        //    Regex pattern = new Regex(@"<a.*?href\s*=\s*['""](.*?)['""].*?>(?:<.*?>)*(.*?)(?:<.*?>)*<\/a>", RegexOptions.IgnoreCase);
        //    MatchCollection matches = pattern.Matches(doc);

        //    foreach (Match m in matches)
        //    {
        //        Console.WriteLine(string.Format("{0},{1}", m.Groups[1].Value.Trim(), m.Groups[2].Value.Trim()));
        //    }

        //    Console.ReadLine();
        //}
    }
}