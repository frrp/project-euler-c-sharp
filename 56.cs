using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution 
{
    static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            BigInteger massive = 0;
            BigInteger largestSum = 0;

            for(int i = 1; i < N; i++)
                for (int j = 1; j < N; j++)
                {
                    massive = BigInteger.Pow(i, j);
                    BigInteger bigSum = DigitSum(massive);
                    largestSum = bigSum > largestSum ? bigSum : largestSum;
                }
            Console.WriteLine(largestSum);
        }

        static BigInteger DigitSum(BigInteger big)
        {
            string bigInt = big.ToString();
            BigInteger sum = 0;

            foreach (char c in bigInt)
                sum += c - '0';
            return sum;
        }
}