using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

class Solution 
{
    static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = Convert.ToInt32(input[0]);
            int K = Convert.ToInt32(input[1]);
        
            SieveOfAtkin(K*N);

            foreach (int p in Primes)
            {
                if (p < 1000)
                    continue;

                for (int i = Primes.IndexOf(p) + 1; i < Primes.Count; i++)
                {
                    int diff = Primes[i] - p;
                    if (K == 3)
                        {
                        if (IsPrime(Primes[i] + diff) && IsPermutation(p, diff))
                            Console.WriteLine("" + p + "" + Primes[i] + "" + (Primes[i] + diff));
                        }
                }
            }
        }

    static bool IsPermutation(int prime1, int diff)
        {
            string primeTwo = (prime1 + diff).ToString();
            string primeThree = (prime1 + diff + diff).ToString();

            string primeOne = prime1.ToString();

            foreach (char c in primeOne)
                if (!primeThree.Contains(c) || !primeTwo.Contains(c))
                    return false;
            foreach (char c in primeTwo)
                if (!primeOne.Contains(c) || !primeThree.Contains(c))
                    return false;
            foreach (char c in primeThree)
                if (!primeOne.Contains(c) || !primeTwo.Contains(c))
                    return false;
            return true;
        }
    
    
    // generating primes:
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
     
    static void GeneratePrimes(int bound)
        {
            Primes = new List<int>();
            Primes.Add(2);
            Primes.Add(3);

            int i = 4;
            while (i <= bound)
            {
                if (IsPrime(i))
                    Primes.Add(i);
                i++;
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