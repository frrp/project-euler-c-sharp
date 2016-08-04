using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());
            for (int z = 0; z < T; z++)
            {
                string[] input = Console.ReadLine().Split();
                string number = "";
                int res = 1;

                for (int i = 0; number.Length <= 10000; i++)
                    number += i;
                for (int j = 0; j <= 6; j++)
                    res *= (number[Convert.ToInt32(input[j])] - '0');

                Console.WriteLine(res);
            }
        }
}