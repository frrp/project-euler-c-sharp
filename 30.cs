using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static int Bound = 360000; // bound on the number of tries
    
    static void Main(string[] args)
        {
            long total = 0;
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 2; i < Bound; i++)
            {
                int sumOfNth = SumOfNthPower(i, N);
                if (sumOfNth == i)
                    total += i;
            }
            Console.WriteLine(total);
        }


        static int SumOfNthPower(int number, int N)
        {
            int[] digits = GetDigits(number);
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
                {
                int temp = digits[i];
                for(int j = 1; j < N; j++)  // faster than Math.Pow
                    temp *= digits[i];
                sum += temp;
                }
            return sum;
        }


        static int[] GetDigits(int number)
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
}