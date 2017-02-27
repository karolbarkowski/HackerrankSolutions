using System;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\StringConstruction\\samples\\testCase0.txt"))
        {
            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(sr.ReadLine().ToCharArray().Distinct().Count());
            }
        }
        Console.ReadLine();
    }
}


