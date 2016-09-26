using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution 
{
    static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            BigInteger sum = new BigInteger();
            BigInteger bigInt = new BigInteger();
            
            for (int i = 1; i <= N; i++)
            {
                bigInt = BigInteger.Pow(i, i);
                sum += bigInt;
            }
            string sumString = sum.ToString();
            string lastTen = sumString.Substring((sumString.Length - 10));
            Console.WriteLine(int.Parse(lastTen));
           }
}