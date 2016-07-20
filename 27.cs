using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    public static int Bound = 3000; // how many primes to generate
    public static List<long> Primes { get; private set; }
    
    static void Main(string[] args)
    {
        GeneratePrimes(Bound);
        int N = Int32.Parse(Console.ReadLine());
        int longest = 0;
        int maxI = 0;
        int maxJ = 0;

        for (int i = -N; i < N+1; i++)
            for (int j = -N; j < N+1; j++)
        {
            int temp = QuadradicPrimes(i, j);
            if (temp > longest)
            {
                longest = temp;
                maxI = i;
                maxJ = j;
            }
        }
        Console.WriteLine("{0} {1}", maxI, maxJ);
    }

    static int QuadradicPrimes(int a, int b)
    {
        int n = 0;
        while (IsPrime(n * n + a * n + b))
            n++;
        return n;
    }

    /// Primes section
    
    public static void GeneratePrimes(long numberOfPrimes)
    {
        Primes = new List<long>();
        Primes.Add(2);
        Primes.Add(3);

        int i = 4;
        while (i <= numberOfPrimes)
        {
            if (IsPrime(i))
                Primes.Add(i);
            i++;
        }
    }

    public static bool IsPrime(int number)
    {
        double squareRoot = Math.Sqrt(number);

        if(squareRoot == (int)squareRoot)
            return false;

        foreach (long i in Primes)
        {
            if (i > squareRoot)
                break;

            if (number % i == 0)
                return false;
        }
        return true;
    }
    /// Primes
}

 