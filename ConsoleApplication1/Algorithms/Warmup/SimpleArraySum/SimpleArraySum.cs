using System;
using System.Linq;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Warmup\\SimpleArraySum\\samples\\testCase0.txt"))
        {
            sr.ReadLine();
            string[] arr_temp = sr.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
        Console.ReadLine();
    }
}


