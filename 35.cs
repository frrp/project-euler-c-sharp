using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
        static List<int> Primes { get; set; }

        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            GeneratePrimes(N);
            int sum = 0;

            foreach (int p in Primes)
            {
                if (IsCircular(p, N))
                    sum += p;
            }
            Console.WriteLine(sum);
        }

        static bool IsCircular(int num, int N)
        {
            if (num < 10)
                return true;
            string numString = num.ToString();

            foreach (char c in numString)
                if ((int)c % 2 == 0)
                    return false;

            int number;
            do
            {
                numString = Rotate(numString);

                number = int.Parse(numString);

                if (!Primes.Contains(number))
                    {
                    if (number < N)
                        return false;
                    else
                        if (!IsPrime(number))
                            return false;
                    }
                                } while (number != num);

            return true;
        }

        static string Rotate(string s)
        {
            if(s.Length==1)
                return s;
            string newString = s.Substring(1) + s[0];
            
            return newString;
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