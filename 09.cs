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
            int N = Int32.Parse(Console.ReadLine());
            int Max = 1;
            int k;
            int j;
            for (int i = 1; i < N-2; i++)
                    {
                        if ((i*i + (N-i)*(N-i)) % (2*(N-i)) == 0)
                            {
                            j = (i*i + (N-i)*(N-i))/(2*(N-i));
                            k = N - i - j;
                            if (k > 0)
                                {
                                if (i * i + k * k == j * j)
                                {
                                    if (i * j * k > Max)
                                        Max = i * j * k;
                                }
                                }
                    }
            }
           if (Max > 1) 
               Console.WriteLine(Max);
           else
               Console.WriteLine("-1");
      }
    }
}