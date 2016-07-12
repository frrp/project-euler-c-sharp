using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static bool IsDivisibleByAll(long num, int N)
        {
            for (int j = 1; j <= N; j++)
                if (num % j != 0)
                    return false;
            return true;
        }
    
    static void Main(String[] args) {
        int T = Int32.Parse(Console.ReadLine());
        for(int z = 0; z < T; z++){
            int N = Int32.Parse(Console.ReadLine());
            long i = 1;

            for (; i < long.MaxValue; i++)
            {
                if (IsDivisibleByAll(i, N))
                    break;
            }
            
            Console.WriteLine(i);
        }
    }
}