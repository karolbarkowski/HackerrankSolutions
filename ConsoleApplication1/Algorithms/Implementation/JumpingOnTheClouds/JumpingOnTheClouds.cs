using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\JumpingOnTheClouds\\samples\\testCase1.txt"))
        {
            sr.ReadLine();
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);

            int playerAt = 0;
            int jumps = 0;
            while (playerAt != arr.Length - 1)
            {
                if (arr.Length - 1 - playerAt == 1) //one to go
                    playerAt++;
                else if (arr[playerAt + 1] == 1 || (arr[playerAt + 1] == 0 && arr[playerAt + 2] == 0)) //next cloud is thundercloud or we got two clear clouds ahead
                    playerAt += 2;
                else if (arr[playerAt + 2] == 1) //thundercloud is second from here
                    playerAt += 1;

                jumps++;
            }
            Console.WriteLine(jumps.ToString());
        }
        Console.ReadLine();
    }
}