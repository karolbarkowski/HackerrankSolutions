using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        string time = Console.ReadLine();
        Regex pattern = new Regex(@"(?<hh>\d{2}):(?<mm>\d{2}):(?<ss>\d{2})(?<tt>\w{2})");
        Match match = pattern.Match(time);

        string hh = match.Groups["hh"].Value;
        string mm = match.Groups["mm"].Value;
        string ss = match.Groups["ss"].Value;
        string tt = match.Groups["tt"].Value;

        if (tt == "AM" && hh == "12") hh = "00";
        if (tt == "PM" && hh != "12") hh = (Int32.Parse(hh) + 12).ToString();

        Console.WriteLine(string.Format("{0}:{1}:{2}", hh, mm, ss));
    }
}