using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("WeekOfCode_23\\02_Lighthouse\\samples\\testCase3.txt"))
        {
            int n = Convert.ToInt32(sr.ReadLine());
            string ground = sr.ReadToEnd().Replace(Environment.NewLine, "|");
            int R = (n - 1) / 2;   //maximum possible radius

            //start from biggest radius possible and decrease it in each iteration
            while (R > 0)
            {
                //calculate how many spaces is needed in each row, depending on the distance from the center
                Dictionary<int, int> spacecNeededInRows = CalculateNeededSpacesInRows(R);

                //construct regex patter
                string pattern = ConstructRegex(n, R, spacecNeededInRows);

                //check if we have a match
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(ground))
                {
                    Console.WriteLine(R.ToString());
                    Console.ReadLine();
                }
                R--;
            }

            Console.WriteLine("0");
        }

        Console.ReadLine();
    }



    private static Dictionary<int, int> CalculateNeededSpacesInRows(int R)
    {
        Dictionary<int, int> spacecNeededInRows = new Dictionary<int, int>();
        for (int i = 0; i <= R; i++)
        {
            spacecNeededInRows[i] = SpaceNeededInRow(R, i);
        }

        return spacecNeededInRows;
    }

    private static string ConstructRegex(int n, int R, Dictionary<int, int> spacecNeededInRows)
    {
        StringBuilder sb = new StringBuilder();
        for (int r = R; r >= -R; r--)
        {
            int spaceNeededInRow = spacecNeededInRows[Math.Abs(r)];
            sb.Append("\\.{" + spaceNeededInRow + "}");

            if (r != -R)    //skip stars in last line
            {
                int nextRowIndex = r > 0 ? r - 1 : Math.Abs(r) + 1;
                int spaceNeededInNextRow = spacecNeededInRows[nextRowIndex];
                int ignoredBlocksToNextRow = ((2 * n) - spaceNeededInRow - spaceNeededInNextRow) / 2;
                ignoredBlocksToNextRow++;   //add one for a character denoting new line (it must be there)
                sb.Append("[\\*\\.\\|]{" + ignoredBlocksToNextRow + "}");
            }

        }
        string pattern = sb.ToString();
        return pattern;
    }

    private static int SpaceNeededInRow(int r, int yDist)
    {
        int sum = 0;
        for (int i = 0; i < (2 * r) + 1; i++)
        {
            int d = Dist(r - yDist, i, r, r);
            if (d <= r)
                sum++;
        }
        return sum;
    }

    private static int Dist(int x1, int y1, int x2, int y2)
    {
        return (int)Math.Ceiling(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
    }
}