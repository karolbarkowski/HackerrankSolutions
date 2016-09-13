using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Solution
{
    private static int[] rotateRight(int[] input, int k)
    {
        //don't do circular moves
        k = k % input.Length;
        int[] output = new int[input.Length];

        for (int i = 0; i <= input.Length - k - 1; i++)
        {
            output[i + k] = input[i];
        }

        int temp = 0;
        for (int i = input.Length - k; i < input.Length; i++)
        {
            output[temp++] = input[i];
        }

        return output;
    }

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Warmup\\CircularArrayRotation\\samples\\testCase0.txt"))
        {
            int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int n = line[0];
            int k = line[1];
            int q = line[2];

            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int[] output = rotateRight(input, k);

            for (int i = 0; i < q; i++)
                Console.WriteLine(output[Int32.Parse(sr.ReadLine())]);
        }
        Console.ReadLine();
    }
}