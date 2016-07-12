using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static long LargestPrimeFactor(long number)
        {
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                    number /= i;
                else
                    i++;
            }
            return number;
        }
    
    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        for(int j = 0; j < T; j++)
        {
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine(LargestPrimeFactor(N));
        }
    }
}