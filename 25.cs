using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution 
{
    static BigInteger fib1 = BigInteger.One;
    static BigInteger fib2 = BigInteger.One;
    static BigInteger count = 2;

    static void Main(string[] args)
    {
        int T = Int32.Parse(Console.ReadLine());
        for (int j = 0; j < T; j++)
            {
            int N = Int32.Parse(Console.ReadLine());
            while (fib2.ToString().Length < N)
            {
                BigInteger nextFib = fib1 + fib2;
 
                fib1 = fib2;
                fib2 = nextFib;
                count++;
            }
            Console.WriteLine(count);
            }
    }
}