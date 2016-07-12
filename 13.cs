using System;
using System.Collections.Generic;
using System.Numerics;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        List<BigInteger> bigInts = new List<BigInteger>();
        //List<string> numbers = new List<string>();     
        int N = Int32.Parse(Console.ReadLine());

        for (int j = 0; j < N; j++)
            bigInts.Add(BigInteger.Parse(Console.ReadLine()));
            
        BigInteger BigOne = new BigInteger(0);

        foreach (BigInteger b in bigInts)
            BigOne += b;

        string bigString = BigOne.ToString();

        for (int i = 0; i < 10; i++)
            Console.Write(bigString[i]);
    }
}