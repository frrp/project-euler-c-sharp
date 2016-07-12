using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution 
{
    public static BigInteger Factorial(int number)
        {
            if (number > 1)
                return Factorial(1, number);
            return 1;
        }
    
    private static BigInteger Factorial(int number, int length)
        {
            if (length > 1)
            {
                int l = length / 2;
                return Factorial(number, l) * Factorial(number + l, length - l);
            }
            return number;
        }
    
    public static BigInteger Binomial(int n, int k)
        {
        // assert n >= 0 and 0 <= k <= n
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
        
    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        
        for(int z = 0; z < T; z++)
        {
            string[] input = Console.ReadLine().Split();
            int N = Convert.ToInt32(input[0]);
            int M = Convert.ToInt32(input[1]);
            Console.WriteLine(Binomial(N + M, M));
        }        
    }
}

