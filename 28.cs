using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args)
    {
        int T = Int32.Parse(Console.ReadLine());
        for (int j = 0; j < T; j++)
            {
            int N = Int32.Parse(Console.ReadLine());
            int elem = 1;
            int step = 2;
            int corner = 0;
            int sum = 1;
            while (step < N-2 || corner != 4)
                {
                if (corner == 4)
                    {
                    step += 2;
                    corner = 0;
                }
                elem += step;
                sum += elem;
                corner++;
            }
            Console.WriteLine(sum % 1000000007);
            }
    }
}

