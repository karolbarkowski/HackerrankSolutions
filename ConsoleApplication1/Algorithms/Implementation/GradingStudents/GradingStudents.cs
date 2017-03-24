using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Implementation\\GradingStudents\\samples\\testCase0.txt"))
        {
            int n = Int32.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int grade = Int32.Parse(sr.ReadLine());

                if (grade < 38)
                {
                    Console.WriteLine(grade);
                }
                else
                {
                    int diff = 5 - (grade % 5);
                    if (diff < 3)
                        Console.WriteLine(grade + diff);
                    else
                        Console.WriteLine(grade);
                }
            }
        }
        Console.ReadLine();
    }
}