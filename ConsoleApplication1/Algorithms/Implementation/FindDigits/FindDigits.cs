using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\FindDigits\\samples\\testCase0.txt"))
        {
            int t = Convert.ToInt32(sr.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string num = sr.ReadLine();
                int n = Convert.ToInt32(num);

                int sum = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    int digit = Byte.Parse(num[i].ToString());

                    if (digit == 0)
                        continue;

                    if (n % digit == 0)
                        sum++;
                }

                Console.WriteLine(sum.ToString());
            }
        }
    }
}