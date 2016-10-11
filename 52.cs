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
            int start = 1;
            bool found = false;
             
            for (int i = start; i < N; i++) 
            {
                found = true;
                for (int j = 2; j <= K; j++) 
                {
                    if (!IsPermutation(i, j * i)) 
                    {
                        found = false;
                        break;
                    }
                }
                if (found) 
                {
                    start = i+1;
                    for (int j = 1; j <= K; j++) 
                        Console.Write(i*j + " ");
                    Console.WriteLine();
                }
            }
        }

    static bool IsPermutation(int n1, int n2) 
    {
        int[] arr = new int[10];

        int temp = n1;
        while(temp > 0)
        {
            arr[temp % 10]++;
            temp /= 10;
        }

        temp = n2;
        while(temp > 0)
        {
            arr[temp % 10]--;
            temp /= 10;
        }

        for(int i = 0; i < 10; i++)
        {
            if(arr[i] != 0)
                return false;
        }
        return true;
    }
}