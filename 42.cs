using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static List<int> triangleNumbers = new List<int>();
        
    static void Main(String[] args) 
    {
        int bound = 9999;
        for (int i = 1; i < bound; i++)
                triangleNumbers.Add(TriangleNumber(i));

        int T = Int32.Parse(Console.ReadLine());
        for (int z = 0; z < T; z++)
            {
            int N = Int32.Parse(Console.ReadLine());
            int found = 0;
            
            for (int j = 0; j < bound-1; j++)
            {
                if (triangleNumbers[j] == N)
                    {
                    Console.WriteLine(j+1);
                    found = 1;
                    break;
                }
            }
            if (found == 0)        
                Console.WriteLine(-1);
        }
        }

        static int TriangleNumber(int n)
            {
            return n * (n + 1) / 2;
            }
}