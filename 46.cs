using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

class Solution 
{
    static void Main(string[] args)
        {
            SieveOfAtkin(500000);
            int T = Int32.Parse(Console.ReadLine());
            for (int z = 0; z < T; z++)
            {
                int N = Int32.Parse(Console.ReadLine());
                int counter = 0;
                
                foreach (int p in Primes)
                {
                    if (p > N)
                        break;

                    double sqrt = Math.Sqrt((N - p) / 2);
                    if (sqrt == (int)sqrt)
                        counter++;
                }
                Console.WriteLine(counter);
            }
        }

    // primes generating part:
    public static List<int> Primes { get; private set; }

    public static void SieveOfAtkin(long max)
    {
        var isPrime = new bool[max + 1];
        var sqrt = (int)Math.Sqrt(max);

        Parallel.For(1, sqrt, x =>
                     {
                         var xx = x * x;
                         for (int y = 1; y <= sqrt; y++)
                         {
                             var yy = y * y;
                             var n = 4 * xx + yy;
                             if (n <= max && (n % 12 == 1 || n % 12 == 5))
                                 isPrime[n] ^= true;

                             n = 3 * xx + yy;
                             if (n <= max && n % 12 == 7)
                                 isPrime[n] ^= true;

                             n = 3 * xx - yy;
                             if (x > y && n <= max && n % 12 == 11)
                                 isPrime[n] ^= true;
                         }
                     });

        Primes = new List<int>() { 2, 3 };
        for (int n = 5; n <= sqrt; n++)
        {
            if (isPrime[n])
            {
                Primes.Add(n);
                int nn = n * n;
                for (int k = nn; k <= max; k += nn)
                    isPrime[k] = false;
            }
        }
        try
        {
            for (int n = sqrt + 1; n <= max; n++)
                if (isPrime[n])
                Primes.Add(n);
        }
        catch (OutOfMemoryException e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }


    static bool IsPrime(int number)
    {
        double squareRoot = Math.Sqrt(number);

        if(squareRoot == (int)squareRoot)
            return false;

        foreach (int i in Primes)
        {
            if (i > squareRoot)
                break;

            if (number % i == 0)
                return false;
        }
        return true;
    }
}