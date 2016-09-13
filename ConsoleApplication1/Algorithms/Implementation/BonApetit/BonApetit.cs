using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\BonApetit\\samples\\testCase0.txt"))
        {
            int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int n = line[0];
            int k = line[1];

            int[] prices = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int charged = Int32.Parse(sr.ReadLine());

            int priceTotal = prices.Sum();
            int priceToShare = priceTotal - prices[k];
            int pricePerPerson = priceToShare / 2;

            Console.WriteLine(pricePerPerson == charged ? "Bon Appetit" : (charged - pricePerPerson).ToString());
        }
        Console.ReadLine();
    }
}