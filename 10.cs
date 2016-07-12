using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static HashSet<int> Primes = new HashSet<int>();

    public static void GeneratePrimes(long num)
        {
            Primes.Add(2);
            Primes.Add(3);
            int i = 4;        
            while (i <= num)
            {
                if (IsPrime(i))
                    Primes.Add(i);
                i++;
            }
        }
    
    static bool IsPrime(int num)
        {
            double squareRoot = Math.Sqrt(num);

            if (squareRoot == (int)squareRoot) // num is square
                return false;

            foreach (int i in Primes)
            {
                if (i > squareRoot)
                    break;

                if (num % i == 0)
                    return false;
            }
            return true;
    }
    
    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        GeneratePrimes(1000000);
        
        for(int z = 0; z < T; z++)
        {
            int N = Int32.Parse(Console.ReadLine());
            long PrimeSum = 0;
            
            foreach (int j in Primes)
            {
                if (j < N+1)
                PrimeSum += j;
            }
            Console.WriteLine(PrimeSum);
        }
    }
}