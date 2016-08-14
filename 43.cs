using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static string pandigitalString = "0123456789";
    static List<int> primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17 };
    static List<string> permutations = new List<string>();

    static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine());
        string NdigitalString = pandigitalString.Substring(0, N+1);
        long sum = 0;
        CreatePermutations(NdigitalString, "");

        foreach (string s in permutations)
            {
            if (Divisible(s, N))
                //Console.WriteLine(s);
                sum += long.Parse(s);
            }
        Console.WriteLine(sum);
            
    }
    
    static bool Divisible(string s, int N)
    {
        if (s[3] % 2 != 0)
                return false;
        // heuristics for larger numbers
        if (s.Length > 5)
            if (s[2]+s[3]+s[4] % 3 != 0 || s[5] != 5)
                return false;
        for (int i = 2; i < N-1; i++)
        {   
            int num = int.Parse(s.Substring(i, 3));
            if (num % primes[i-1] != 0)
                return false;
        }
        return true;
    }

    static void CreatePermutations(string digits, string number)
    {
        string newDigits = String.Copy(digits);

        if (digits.Length == 1)
        {
            number += digits[0];
            permutations.Add(number);
        }
        foreach (char c in digits)
        {
            if (c == '0' && digits.Length == 10)
                continue;

            newDigits = newDigits.Remove(newDigits.IndexOf(c), 1);
            string num = String.Copy(number) + c;
            CreatePermutations(newDigits, num);
            newDigits += c;
        }
    }
}
