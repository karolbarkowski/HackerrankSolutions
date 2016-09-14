using System;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Mathematics\\Fundamentals\\FindPoint\\samples\\testCase0.txt"))
        {
            int N = Int32.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int[] cords = Array.ConvertAll(sr.ReadLine().Split(' '), Int32.Parse);
                int Px = cords[0];
                int Py = cords[1];
                int Qx = cords[2];
                int Qy = cords[3];

                int Nx = (2 * Qx) - Px;
                int Ny = (2 * Qy) - Py;

                Console.WriteLine(string.Format("{0} {1}", Nx, Ny));
            }
        }

        Console.ReadLine();
    }
}