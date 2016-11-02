using System;
using System.IO;

class Solution
{
    private static int[][] readMatrix(int N, StreamReader sr)
    {
        int[][] matrix = new int[N][];

        for (int i  =0; i < N; i++)
        {
            matrix[i] = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        }
        return matrix;
    }

    static void Main(string[] args)
    {

        using (StreamReader sr = new StreamReader("Algorithms\\ConstructiveAlgorithms\\FlippingTheMatrix\\samples\\sample0.txt"))
        {
            int q = int.Parse(sr.ReadLine());

            for (int i = 0; i < q; i++)
            {
                int n = int.Parse(sr.ReadLine());
                int[][] matrix = readMatrix(2 * n, sr);


            }

            Console.ReadLine();
        }
    }
}