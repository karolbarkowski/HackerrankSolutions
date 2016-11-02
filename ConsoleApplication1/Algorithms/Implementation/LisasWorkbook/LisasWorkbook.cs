using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\LisasWorkbook\\samples\\testCase0.txt"))
        {
            int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int n = line[0];
            int k = line[1];
            int[] chapters = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);

        }
    }
}