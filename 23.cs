using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution 
{
    static BigInteger sum = BigInteger.Zero;

    static void Main(string[] args)
    {
        int T = Int32.Parse(Console.ReadLine());
        for (int j = 0; j < T; j++)
            {
            int N = Int32.Parse(Console.ReadLine());
            if (CanBeWrittenAsTwoAbundants(N))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            }
    }

    static bool CanBeWrittenAsTwoAbundants(int number)
    {
        int num1 = 1;
        int num2 = number - 1;

        while (num1 <= num2)
        {
            if (IsAbundant(num1) && IsAbundant(num2))
                return true;

            num1++; num2--;
        }
        return false;
    }

    static bool IsAbundant(int number)
    {
        int divisorSum = DivisorSum(number);
        return (divisorSum > number);
    }

    static int DivisorSum(int number)
    {
        int divisorSum = 0;
        
        for (int i = 1; i <= number / 2; i++)
            if (number % i == 0)
                divisorSum += i;
        return divisorSum;
    }
}