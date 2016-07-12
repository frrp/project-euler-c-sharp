using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    const int SIZE = 20;

    static int[,] matrix = new int[SIZE+1, SIZE];

    static void GetMatrix()
        {
            for (int j = 0; j < SIZE; j++)
                {
                string line = Console.ReadLine();
                string[] nums = line.Split(' ');
                int i = 0;
                foreach (string s in nums)
                {
                    matrix[i, j] = int.Parse(s);
                    i++;
                }
                
            }
        }
    
    static int GetMaxProd(int i, int j)
        {
            int prod1 = 0, prod2 = 0, prod3 = 0, prod4 = 0;

            // right
            if (i < SIZE - 3)
                prod1 = matrix[i, j] * matrix[i + 1, j] * matrix[i + 2, j] * matrix[i + 3, j];
            // down
            if (j < SIZE - 3)
                prod2 = matrix[i, j] * matrix[i, j + 1] * matrix[i, j + 2] * matrix[i, j + 3];
            // diagonal down
            if (i < SIZE - 3 && j < SIZE - 3)
                prod3 = matrix[i, j] * matrix[i + 1, j + 1] * matrix[i + 2, j + 2] * matrix[i + 3, j + 3];
            // diagonal up
            if (i < SIZE - 3 && j > 2)
                prod4 = matrix[i, j] * matrix[i + 1, j - 1] * matrix[i + 2, j - 2] * matrix[i + 3, j - 3];
                
            return Math.Max(Math.Max(prod1, prod2), Math.Max(prod3, prod4));
        }
    
    static void Main(String[] args) 
    {
        GetMatrix();
        long max = 0, Max = 0;
        
        for(int i = 0; i < SIZE; i++)
        {
            for(int j = 0; j < SIZE; j++)
            {
                max = GetMaxProd(i, j);
                if (max > Max)
                    Max = max;
            }    
        }
        Console.WriteLine(Max);
    }
}