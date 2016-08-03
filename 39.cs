using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(string[] args)
        {
        int T = Int32.Parse(Console.ReadLine());
        for (int z = 0; z < T; z++)
            {
            int N = Int32.Parse(Console.ReadLine());
            int pMax = 0;
            int tMax = 0;           
            int m = 0;
            int k = 0;
            
            for (int s = 1; s <= N; s++) 
            {
                int t = 0;
                int mlimit = (int)Math.Sqrt(s / 2);
                for (m = 2; m <= mlimit; m++) 
                {
                    if ((s / 2) % m == 0) 
                    {                    
                        if (m % 2 == 0)
                            k = m + 1;
                        else
                            k = m + 2;
                        
                        while (k < 2 * m && k <= s / (2 * m)) 
                        {
                            if (s / (2 * m) % k == 0 && gcd(k, m) == 1) 
                                t++;
                            k += 2;
                        }
                    }                    
                }
                if (t > tMax) 
                {
                    tMax = t;
                    pMax = s;
                }
            }
            Console.WriteLine(pMax);
            }
        }
    
    static public int gcd(int a, int b) 
        {
            int y = 0;
            int x = 0;

            if (a > b) 
            {
                x = a;
                y = b;
            }
            else 
            {
                x = b;
                y = a;
            }

            while (x % y != 0) 
            {
                int temp = x;
                x = y;
                y = temp % x;
            }
            return y;
        }
}
