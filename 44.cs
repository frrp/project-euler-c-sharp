using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static List<long> Pnumbers = new List<long>();
        
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = Convert.ToInt32(input[0]);
        int K = Convert.ToInt32(input[1]);
        List<long> result = new List<long>();
        int bound = 10;

        for (int i = 2; i <= N+bound; i++)
            Pnumbers.Add(PentagonalNumber(i));

        foreach (long p in Pnumbers)
        {
            int index = Pnumbers.IndexOf(p);
            if (index-K >= 0 && index < N)
                //Console.WriteLine("The diff is {0}, p is {1}", p - Pnumbers[index-K], p);
                if (IsPentagonal(p - Pnumbers[index-K]) || IsPentagonal(p + Pnumbers[index-K]))
                    result.Add(p);
        }
        foreach (long r in result)
            Console.WriteLine(r);
    }

    
    static bool IsPentagonal(long num)
    {
        return Pnumbers.BinarySearch(num) >= 0;
    }

    
    static long PentagonalNumber(int number)
    {
        return number * (3 * number - 1) / 2;
    }
}