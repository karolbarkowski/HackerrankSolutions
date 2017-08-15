using System;
using System.IO;

static class Extensions
{
    public static void Swap(this int[] arr, int x, int y)
    {
        int temp = arr[x];
        arr[x] = arr[y];
        arr[y] = temp;
    }
}

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("CrackingTheCodingInterview\\SortingBubbleSort\\samples\\sample.txt"))
        {
            sr.ReadLine();
            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
            int total = 0;


            for (int i = 0; i < input.Length; i++)
            {
                int swaps = 0;
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input [j + 1])
                    {
                        input.Swap(j, j + 1);
                        swaps++;
                    }
                }

                if (swaps == 0) break;

                total += swaps;
            }

            Console.WriteLine(string.Format("Array is sorted in {0} swaps.", total));
            Console.WriteLine(string.Format("First Element: {0}", input[0]));
            Console.WriteLine(string.Format("Last Element: {0}", input[input.Length - 1]));
            Console.ReadLine();
        }
    }
}