using System;
using System.IO;
using System.Numerics;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Mathematics\\Fundamentals\\Handshake\\samples\\testCase0.txt"))
        {
            int N = Int32.Parse(sr.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int n = Int32.Parse(sr.ReadLine());
                Console.WriteLine(n <= 1 ? "0" : (((n - 1) * n) / 2).ToString());
            }
        }

        Console.ReadLine();
    }
}