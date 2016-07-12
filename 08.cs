using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        for(int z = 0; z < T; z++)
        {
            string[] input = Console.ReadLine().Split();
            int N = Convert.ToInt32(input[0]);
            int K = Convert.ToInt32(input[1]);
            string number = Console.ReadLine();
            List<int> theNumber = new List<int>();
            int largestProduct = 0;
            
            for (int j = 0; j < number.Length; j++)
                theNumber.Add((int)Char.GetNumericValue(number[j]));
            if (theNumber.Count != N)
                Console.WriteLine("wrong number length!");
            for (int i = 0; i < theNumber.Count - K; i++)
            {
                int product = 1;
                for(int k = 0; k < K; k++)
                    product *= theNumber[i + k];
                
                if (product > largestProduct)
                    largestProduct = product;
            }
            Console.WriteLine(largestProduct);
            }
    }
}