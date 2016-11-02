using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("CrackingTheCodingInterview\\LonelyInteger\\samples\\sample2.txt"))
        {
            sr.ReadLine();
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);

            int num = 0;

            for (int i = 0; i < arr.Length; i++)
                num ^= arr[i];

            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}