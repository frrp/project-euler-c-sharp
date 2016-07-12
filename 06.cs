using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        for(int z = 0; z < T; z++)
        {
            int N = Int32.Parse(Console.ReadLine());
            
            int n = 1;
            long sumSquares = 0, squareSums = 0;
            
            while (n <= N)
            {
                sumSquares += n * n;
                squareSums += n;
                n++;
            }
            squareSums *= squareSums;
            long diff = squareSums - sumSquares;
            Console.WriteLine(diff);
        }
    }
}