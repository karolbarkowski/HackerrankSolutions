//using System;
//using System.IO;
//using System.Linq;

//class Solution
//{
//    private static int CalculateCombinations(int N)
//    {
//        if (N < 4)
//            return 1;

//        int vBricks = N % 4;
//        int n = 0;
//        while (vBricks < N)
//        {
//            n += vBricks + 1;
//            vBricks += 4;
//        }
//        n++;    //add last case where all bricks are vertical

//        return n;
//    }

//    private static int count(int[] S, int m, int n)
//    {

//        // We need n+1 rows as the table is consturcted in bottom up manner using 
//        // the base case 0 value case (n = 0)
//        int[][] table = new int[n + 1][];
//        for (int i = 0; i < table.Length; i++)
//        {
//            table[i] = new int[m];
//        }

//        // Fill the enteries for 0 value case (n = 0)
//        for (int i = 0; i < m; i++)
//            table[0][i] = 1;

//        // Fill rest of the table enteries in bottom up manner  
//        int x, y;
//        for (int i = 1; i < n + 1; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                // Count of solutions including S[j]
//                x = (i - S[j] >= 0) ? table[i - S[j]][j] : 0;

//                // Count of solutions excluding S[j]
//                y = (j >= 1) ? table[i][j - 1] : 0;

//                // total count
//                table[i][j] = x + y;
//            }
//        }
//        return table[n][m - 1];
//    }

//    private static int CountPrimes(int N)
//    {
//        int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191 };
//        return primes.Where(p => p <= N).Count();
//    }

//    static void Main(String[] args)
//    {
//        using (StreamReader sr = new StreamReader("Algorithms\\DynamicProgramming\\RedJohnIsBack\\samples\\testCase1.txt"))
//        {
//            int T = Int32.Parse(sr.ReadLine());

//            for (int i = 0; i < T; i++)
//            {
//                int n = Int32.Parse(sr.ReadLine());
//                int[] S = new int[] { 1, 4 };

//                int test = count(S, S.Length, n);

//               // int com = CalculateCombinations(N);
//               // int p = CountPrimes(com);

//                Console.WriteLine(test);
//            }
//        }
//        Console.ReadLine();
//    }
//}