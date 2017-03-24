using System;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader("Algorithms\\Strings\\CaesarCipher\\samples\\testCase5.txt"))
        {
            sr.ReadLine();
            string S = sr.ReadLine();
            int key = int.Parse(sr.ReadLine()) % 26;

            foreach (char c in S)
            {
                char cNew = c;

                if (c >= 'A' && c <= 'Z')
                {
                    cNew = (char)(cNew + key);
                    if (cNew > 'Z')
                        cNew = (char)(cNew - 26);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    cNew = (char)(cNew + key);
                    if (cNew > 'z')
                        cNew = (char)(cNew - 26);
                }

                Console.Write(cNew);
            }
            Console.Write(Environment.NewLine);
        }
        Console.ReadLine();
    }
}


