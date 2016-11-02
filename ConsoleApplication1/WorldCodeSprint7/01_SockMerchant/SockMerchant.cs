using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("WorldCodeSprint7\\01_SockMerchant\\samples\\testCase0.txt"))
        {
            sr.ReadLine();
            int[] c = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);

            Dictionary<int, int> set = new Dictionary<int, int>();
            for (int i = 0; i < c.Length; i++)
            {
                if (!set.ContainsKey(c[i]))
                    set[c[i]] = 0;

                set[c[i]]++;
            }

            int sum = 0;
            foreach (int key in set.Keys)
            {
                sum += set[key] / 2;
            }

            Console.WriteLine(sum);
        }

        Console.ReadLine();
    }
}