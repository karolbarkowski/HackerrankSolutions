using System;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\FunnyString\\samples\\testCase0.txt"))
        {
            int T = int.Parse(sr.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string S = sr.ReadLine();

                bool eq = true;
                for (int j = 0; j < S.Length - 2; j++)
                {
                    int Si = (int)S[j];
                    int Si2 = (int)S[j + 1];

                    int Ri = (int)S[S.Length - 1 - j];
                    int Ri2 = (int)S[S.Length - 2 - j];

                    eq = Math.Abs(Si - Si2) == Math.Abs(Ri - Ri2);
                    if (!eq)
                    {
                        break;
                    }
                }
                Console.WriteLine(eq ? "Funny" : "Not Funny");
            }

        }
        Console.ReadLine();
    }
}


