using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution 
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = Convert.ToInt32(input[0]);
        int K = Convert.ToInt32(input[1]);
        int answer = 0;
        BigInteger[] fac = factorials(N);

        for (int i = 1; i <= N; i++)
            for (int j = 1; j <= i; j++)
                if (fac[i] / (fac[j] * fac[i-j]) > K)
                    answer++;
        Console.WriteLine(answer);
    }

    // caching factorials
    static BigInteger[] factorials(int x) 
    {
        if (x < 0) return null;

        BigInteger[] y = new BigInteger[x+1];
        y[0] = 1;

        for (int i = 1; i <= x; i++) 
            y[i] = y[i-1]*i;
        return y;
    }
}