using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("CrackingTheCodingInterview\\LeftRotation\\samples\\sample.txt"))
        {
            string[] line = sr.ReadLine().Split(' ');
            var d = Int32.Parse(line[1]);
            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int[] output = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (i >= d)
                {
                    output[i - d] = input[i];
                }
                else {
                    output[input.Length - d + i] = input[i];
                }
            }

            Console.WriteLine(string.Join(" ", output));
            Console.ReadLine();
        }
    }
}