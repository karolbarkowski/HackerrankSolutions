using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\MinimumDistances\\samples\\testCase0.txt"))
        {
            sr.ReadLine();
            string[] A_temp = sr.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(A_temp, Int32.Parse);

            int li = 0;
            int ri = 1;
            int? dist = null;

            for (int i = li; i < A.Length - 1; i++)
            {
                for (int j = ri; j < A.Length; j++)
                {
                    if (i == j)
                        continue;

                    if (A[i] == A[j])
                    {
                        int d = Math.Abs(j - i);
                        if (d < dist || !dist.HasValue)
                        {
                            dist = d;
                        }
                    }

                    ri++;
                }
                li++;
                ri = li + 1;
            }

            Console.WriteLine(dist.HasValue ? dist.ToString() : "-1");
        }
    }
}