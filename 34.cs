using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static List<int> curious = new List<int>();
    
    static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int sum = 0;
            Dictionary<int, int> factorials = new Dictionary<int, int>();

            for (int i = 0; i < 10; i++)
                factorials.Add(i, Factorial(i));

            for (int i = 10; i < N; i++)
            {
                int[] digits = GetDigitArray(i);

                long sumOfFacts = 0;

                foreach (int j in digits)
                    sumOfFacts += factorials[j];

                if (curious.Contains(i))
                    sum += i;
                else
                    if (sumOfFacts % i == 0)
                        {
                        sum += i;
                        curious.Add(i);
                        }
            }
            Console.WriteLine(sum);
        }

        static int[] GetDigitArray(int number)
        {
            int length = number.ToString().Length;
            int[] digits = new int[length];

            for (int i = length - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }

        static int Factorial(int n)
        {
            return n == 1 || n == 0 ? 1 : n * Factorial(n - 1);
        }
}