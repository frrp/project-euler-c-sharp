using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution 
{
    static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            List<BigInteger> palindromes = new List<BigInteger>();
            for (int i = 1; i < N; i++)
                palindromes.Add(Lychreal(i));
            
        var palsorted = palindromes.GroupBy( i => i ).OrderByDescending(group => group.Count()).Take(1);

        //IEnumerable<string> e = (from char c in source
        //                select new { Data = c.ToString() }).Select(t = > t.Data);
        
        Console.WriteLine( "{0} {1}", palsorted.Palindrome, palsorted.Count );
        }

        static bool IsAPalindrome(string numString)
        {
            if (numString.Length == 1)
                return true;
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

        // returns the palindrome or zero
        static BigInteger Lychreal(int number)
        {
            BigInteger nextNum = number;

            for (int i = 0; i < 60; i++)
            {
                BigInteger reverse = BigInteger.Parse(Reverse(nextNum.ToString()));
                nextNum = nextNum + reverse;

                if (IsAPalindrome((nextNum).ToString()))
                    return nextNum;
            }
            return 0;
        }

        static string Reverse(string str)
        {
            if (str == null) return null;

            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
}
