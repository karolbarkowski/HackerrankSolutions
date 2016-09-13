using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("30DaysOfCode\\11_2DArrays\\samples\\testCase0.txt"))
        {
            int A = 6;
            int[][] arr = new int[A][];

            for (int i = 0; i < A; i++)
            {
                int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
                arr[i] = line;
            }

            List<int> sums = new List<int>();
            for (int x = 1; x < A -1; x++)
            {
                for (int y = 1; y < A - 1; y++)
                {
                    int sum = arr[x][y];
                    sum += arr[x - 1][y - 1];
                    sum += arr[x - 1][y];
                    sum += arr[x - 1][y + 1];
                    sum += arr[x + 1][y - 1];
                    sum += arr[x + 1][y];
                    sum += arr[x + 1][y + 1];
                    sums.Add(sum);
                }
            }

            Console.WriteLine(sums.Max());
        }

        Console.ReadLine();
    }
}