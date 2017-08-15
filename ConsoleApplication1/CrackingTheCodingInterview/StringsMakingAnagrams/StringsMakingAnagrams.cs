using System;
using System.IO;

static class Extensions
{
    public static int[] GetCharsArray(this string input)
    {
        int[] chars = new int[26];

        foreach (char c in input)
        {
            chars[(int)c - 97]++;
        }

        return chars;
    }

    public static int GetTotalDifference(this int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            throw new ArgumentException("Arrays must have the same length");

        int total = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            total += Math.Abs(arr1[i] - arr2[i]);
        }

        return total;
    }
}

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("CrackingTheCodingInterview\\StringsMakingAnagrams\\samples\\sample.txt"))
        {
            string in1 = sr.ReadLine();
            string in2 = sr.ReadLine();

            int[] chars1 = in1.GetCharsArray();
            int[] chars2 = in2.GetCharsArray();
            int diff = chars1.GetTotalDifference(chars2);

            Console.WriteLine(diff);
            Console.ReadLine();
        }
    }
}