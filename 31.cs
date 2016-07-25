using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        for (int z = 0; z < T; z++)
            {
            int N = Int32.Parse(Console.ReadLine());
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[] ways = new int[N+1];
            ways[0] = 1;

            for (int i = 0; i < coins.Length; i++) {
                for (int j = coins[i]; j <= N; j++) {
                    ways[j] += ways[j - coins[i]];
                }
            }
            Console.WriteLine(ways[ways.Length-1] % 1000000007);
        }
    }
}