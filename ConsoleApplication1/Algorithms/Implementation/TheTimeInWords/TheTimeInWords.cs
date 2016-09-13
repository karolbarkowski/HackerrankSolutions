using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    private static string hourName(int hour)
    {
        switch (hour)
        {
            case 0: return "midnight";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "one";
            default: return "";
        }
    }
    private static string minutesName(int minute)
    {
        switch (minute)
        {
            case 0: return "o' clock";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "quarter";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            case 19: return "nineteen";
            case 20: return "twenty";
            case 21: return "twenty one";
            case 22: return "twenty two";
            case 23: return "twenty three";
            case 24: return "twenty four";
            case 25: return "twenty five";
            case 26: return "twenty six";
            case 27: return "twenty seven";
            case 28: return "twenty eight";
            case 29: return "twenty nine";
            case 30: return "half";
            default: return "";
        }
    }
    private static string separatorName(int minute)
    {
        if (minute == 0)
            return "";
        else if (minute <= 30)
            return "past";
        else
            return "to";
    }
    private static string minutesStringName(int minute)
    {
        if (minute == 0 || minute == 15 || minute == 30 || minute == 45)
            return "";
        else if (minute == 1 || minute == 59)
            return " minute";
        else
            return " minutes";
    }

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\TheTimeInWords\\samples\\testCase2.txt"))
        {
            int h = Convert.ToInt32(sr.ReadLine());
            int m = Convert.ToInt32(sr.ReadLine());

            string minute = minutesName(m <= 30 ? m : 60 - m);
            string minuteString = minutesStringName(m);
            string separator = separatorName(m);
            string hour = hourName(m <= 30 ? h : h + 1);

            if (m == 0)
            {
                Console.WriteLine(string.Format("{0} {1}", hour, minute));
            }
            else {
                Console.WriteLine(string.Format("{0}{1} {2} {3}", minute, minuteString, separator, hour));
            }
            Console.ReadLine();
        }
    }
}