using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution 
{
    static void Main(string[] args)
        {
            SortedSet<BigInteger> Numbers = new SortedSet<BigInteger>();
            int N = Int32.Parse(Console.ReadLine());

            for(int i = 2; i <= N; i++)
                for(int j = 2; j <= N; j++)
                    Numbers.Add(BigInteger.Pow(i,j));

            Console.WriteLine(Numbers.Count);
        }
}