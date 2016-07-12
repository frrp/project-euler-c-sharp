using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution 
{
    static void Main(String[] args) 
        {
        int T = Int32.Parse(Console.ReadLine());
        for (int j = 0; j < T; j++)
            {
            int num = Int32.Parse(Console.ReadLine());
            
            BigInteger nFactorial = new BigInteger();
            
            nFactorial = Factorial(num);

            string number = nFactorial.ToString();

            int sumOfNumbers = 0;

            foreach (char c in number)
                sumOfNumbers += int.Parse(c.ToString());

            Console.WriteLine(sumOfNumbers);
        }
    }
    
    static BigInteger Factorial(int n)
        {
            BigInteger fact = new BigInteger(1);

            while (n > 0)
            {
                fact *= n;

                n--;
            }

            return fact;
        }
}