using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static List<int> primes = new List<int>();

    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        
        primes.Add(2);
        primes.Add(3);
        int i = 5;
        
        for(int z = 0; z < T; z++)
        {
            int N = Int32.Parse(Console.ReadLine());
            
            while (primes.Count < N)
            {
                if (IsPrime(i))
                    primes.Add(i);
                i++;
            }
            Console.WriteLine(primes[N-1]);
        }
    }
    
        static bool IsPrime(int num)
        {
            double squareRoot = Math.Sqrt(num);

            if (squareRoot == (int)squareRoot) // num is square
                return false;

            foreach (int i in primes)
            {
                if (i > squareRoot)
                    break;

                if (num % i == 0)
                    return false;
            }
            return true;
    }
}