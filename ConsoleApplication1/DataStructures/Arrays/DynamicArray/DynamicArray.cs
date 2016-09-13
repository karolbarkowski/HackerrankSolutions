using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("DataStructures\\Arrays\\DynamicArray\\samples\\case6.txt"))
        {
            var line = sr.ReadLine();
            var lineParams = line.Split(new char[] { ' ' });

            var N = Int32.Parse(lineParams[0]);
            var Q = Int32.Parse(lineParams[1]);

            List<int>[] seqList = new List<int>[N];
            for (int i = 0; i < N; i++)
            {
                seqList[i] = new List<int>();
            }
            int lastAns = 0;

            for (int i = 0; i < Q; i++)
            {
                lineParams = sr.ReadLine().Split(new char[] { ' ' });
                int x = Int32.Parse(lineParams[1]);
                int y = Int32.Parse(lineParams[2]);
                int index = (x ^ lastAns) % N;
                List<int> seq = seqList[index];

                switch (lineParams[0])
                {
                    case "1":
                        seq.Add(y);
                        break;
                    case "2":
                        lastAns = seq[y % seq.Count];
                        Console.WriteLine(lastAns);
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}