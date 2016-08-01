using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Solution 
{
        static SortedSet<int> Primes;
        static List<long> truncatablePrimes = new List<long>();
    
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            Primes = FindPrimesBySieveOfAtkins(N);
            
            foreach (int p in Primes)
            {
                if (IsTruncatable(p))
                    truncatablePrimes.Add(p);
            }
            Console.WriteLine(truncatablePrimes.Sum());
        }

        static bool IsTruncatable(long prime)
        {
            if (prime < 10)
                return false;

            string numString = prime.ToString();

            for (int i = 1; i < numString.Length; i++)
            {
                int back = int.Parse(numString.Substring(i));
                int front = int.Parse(numString.Substring(0, numString.Length - i));
                
                if (!truncatablePrimes.Contains(front))
                    if(!Primes.Contains(front))
                        return false;
                if (!truncatablePrimes.Contains(back))
                    if (!Primes.Contains(back))
                        return false;
            }
            return true;
        }

        static SortedSet<int> FindPrimesBySieveOfAtkins(int max)
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

            var primes = new SortedSet<int>() { 2, 3 };
            for (int n = 5; n <= sqrt; n++)
            {
                if (isPrime[n])
                {
                    primes.Add(n);
                    int nn = n * n;
                    for (int k = nn; k <= max; k += nn)
                        isPrime[k] = false;
                }
            }
            try
            {
                for (int n = sqrt + 1; n <= max; n++)
                    if (isPrime[n])
                        primes.Add(n);
            }
            catch (OutOfMemoryException e)
                {}
            return primes;
        }
}