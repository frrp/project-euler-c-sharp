using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = Convert.ToInt32(input[0]);
            int K = Convert.ToInt32(input[1]);
            int sum = 1;
            for (int i = 2; i < N; i++)
            {
                if (IsAPalindrome(i.ToString()))
                    // converting int to string in base K
                    // but only for i within Int16 !
                    if (IsAPalindrome(Convert.ToString(i, K))) 
                        sum += i;
            }
            Console.WriteLine(sum);
        }

        static bool IsAPalindrome(string s)
        {
            int back = s.Length - 1;
            int front = 0;

            while (back > front)
            {
                if (!s[front].Equals(s[back]))
                    return false;
                back--;
                front++;
            }
            return true;
        }
}