using System;
using System.Collections;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\GameOfThronesI\\samples\\testCase1.txt"))
        {
            string s = sr.ReadLine();

            Hashtable ht = new Hashtable(s.Length);
            int oddCount = 0;
            foreach (char c in s)
            {
                //toggle between true/false values to indicate if given letter occured odd or even number of times
                if (ht.ContainsKey(c))
                {
                    ht[c] = !(bool)ht[c];
                    if ((bool)ht[c]) oddCount--;
                    if (!(bool)ht[c]) oddCount++;
                }
                else {
                    ht[c] = false;
                    oddCount++;
                }
            }

            Console.WriteLine(oddCount <= 1 ? "YES" : "NO");
        }
        Console.ReadLine();
    }
}


