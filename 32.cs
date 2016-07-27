using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
        static List<int> products = new List<int>();

        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            string pandigitalString = "1234";
            if (N > 4)
                {
                for (int z = 5; z < N+1; z++)
                    pandigitalString = pandigitalString + z;
            }
            for (int i = 1; i < 1000; i++)
                for (int j = 1; j < 100; j++)
                {
                    int product = i * j;
                if (!products.Contains(product) && IsPandigital(i.ToString() + j.ToString() + product.ToString(), pandigitalString))
                    products.Add(product);
                }
            Console.WriteLine(products.Sum());
        }

        static bool IsPandigital(string number, string pandigitalString)
        {
            if (number.Length != pandigitalString.Length)
                    return false;
            foreach (char c in pandigitalString)
            {
                if (!number.Contains(c))
                    return false;
            }
            return true;
        }
}