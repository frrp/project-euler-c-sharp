using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static int[] cache = new int[5000000];
    
    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        cache[0] = 1;

        for (int j = 0; j < T; j++)
            {
            int maxTerms = 0;
            int theNumber = 0;
            int terms;
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < N+1; i++)
                {
                   terms = CollatzChain(i);
                
                if (terms >= maxTerms)
                    {
                    maxTerms = terms;
                    theNumber = i;
                    }
                }
        Console.WriteLine(theNumber);        
        }
    }

    static int CollatzChain(int num)
    {
        int terms = 1;
        long number = num;
        while (number != 1)
        {
            if (cache[number-1] > 0)
                {
                terms = cache[number-1] + terms;
                cache[num-1] = terms;
                return terms;
                }
            else
            {
                if (number % 2 == 0)
                    number /= 2;
                else
                    number = 3 * number + 1;
                terms++;
            }
        }
        cache[num-1] = terms;
        return terms;
    }
}
