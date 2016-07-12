using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static bool IsPalindrome(int num)
        {
            string numString = num.ToString();

            int back = numString.Length - 1;
            int front = 0;

            while (back > front)
            {
                if (!numString[front].Equals(numString[back]))
                    return false;
                back--;
                front++;
            }
            return true;
        }
    
    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        for(int z = 0; z < T; z++)
        {
            int N = Int32.Parse(Console.ReadLine());
            int largest = 0;

            for (int i = 100; i < 1000; i++)
                for (int j = 100; j < 1000; j++)
                    largest = i * j > largest && i * j < N && (IsPalindrome(i * j)) ? i * j : largest;
            
            Console.WriteLine(largest);
        }
    }
}