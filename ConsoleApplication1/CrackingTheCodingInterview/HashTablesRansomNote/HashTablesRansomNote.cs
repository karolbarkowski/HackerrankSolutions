using System;
using System.Collections;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("CrackingTheCodingInterview\\HashTablesRansomNote\\samples\\sample.txt"))
        {
            sr.ReadLine();
            Hashtable magazineSet = sr.ReadLine().ToWordsCountTable();
            string[] noteWords = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string noteWord in noteWords)
            {
                if (magazineSet.ContainsKey(noteWord))
                {
                    int magWordCount = (int)magazineSet[noteWord];

                    if (magWordCount == 0)
                    {
                        Console.WriteLine("No");
                        Console.ReadLine();
                    }

                    magazineSet[noteWord] = (int)magazineSet[noteWord] - 1;
                }
            }

            Console.WriteLine("Yes");
            Console.ReadLine();
        }
    }
}

static class Extensions
{
    public static Hashtable ToWordsCountTable(this string input)
    {
        Hashtable result = new Hashtable();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string w in words)
        {
            result[w] = result[w] != null ? (int)(result[w]) + 1 : 1;
        }

        return result;
    }
}