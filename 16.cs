using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution 
{
    static void Main(string[] args)
    {
        int T = Int32.Parse(Console.ReadLine());
        for (int j = 0; j < T; j++)
            {
            int N = Int32.Parse(Console.ReadLine());
            BigInteger theNumber = BigInteger.Pow(2, N);
            string numString = theNumber.ToString();
            int sum = 0;
            foreach (char c in numString)
                sum += (int)Char.GetNumericValue(c);
            Console.WriteLine(sum);
            }
    }
}