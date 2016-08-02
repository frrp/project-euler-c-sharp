using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = Convert.ToInt32(input[0]);
        int K = Convert.ToInt32(input[1]);
        string pandigit = "123456789";
        if (K == 8)
            pandigit = "12345678";
        
        for (int i = 2; i < N; i++)
        {
            string number = i.ToString();

            for (int j = 2; j < 10; j++)
            {
                int next = i * j;
                number += next.ToString();

                if (number.Length > 9)
                    break;
                else if (number.Length > 8 & K == 8)
                    break;
                else if (number.Length > 7)
                {
                    if (IsPandigital(number, pandigit))
                        Console.WriteLine(i);
                }
            }
        }
    }

    static bool IsPandigital(string number, string pandigit)
    {
        foreach (char c in pandigit)
        {
            if (!number.Contains(c))
                return false;
        }
        return true;
    }
}