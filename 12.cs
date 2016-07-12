using System;
using System.Collections.Generic;
using System.IO;

class Solution 
    {
    public static Dictionary<long, Int32> DivNums = new Dictionary<long, Int32>();

    static void Main(String[] args) 
        {
        int T = Int32.Parse(Console.ReadLine());
        int divisorCount;
        long triangleNum = 0;
        DivNums.Add(1, 1);
        DivNums.Add(2, 2);
        for(int j = 0; j < T; j++)
            {
            int N = Int32.Parse(Console.ReadLine());
            if (N == 1)
                Console.WriteLine(3);
            else
                {
                int num = 1;
                bool done = false;
                int div1 = 1;
                int div2 = 1;
                int d1, d2;
                while (!done)
                {
                    triangleNum = TriangleNumber(num);
                    if (num % 2 == 0)
                        {
                        d1 = num/2;
                        d2 = num + 1;
                        }
                    else
                        {
                        d1 = num;
                        d2 = (num + 1)/2;
                        }
                        
                    if (DivNums.ContainsKey(d1))
                        div1 = DivNums[d1];
                    else
                        {
                        div1 = Divisors(d1);
                        DivNums.Add(d1, div1);
                        }
                    if (DivNums.ContainsKey(d2))
                        div2 = DivNums[d2];
                    else
                        {
                        div2 = Divisors(d2);
                        DivNums.Add(d2, div2);
                        }
                    divisorCount = div1*div2;
                    if (!DivNums.ContainsKey(triangleNum))
                        DivNums.Add(triangleNum, divisorCount);
                    //Console.WriteLine("divisorCount: " + divisorCount + " triangleNum: " + triangleNum);
                    if (divisorCount > N)
                        done = true;
                    num++;
                }
                Console.WriteLine( triangleNum );
              }
            }
        }

    public static int Divisors(long num)
        {
                int factors = 2;
                double top = (int)Math.Sqrt(num);
                long n = num;
                int i = 2;
                while (n != 1 && i < top + 1)
                {
                    if (num % i == 0)
                    {
                        n = num / i;
                        factors += 2;
                    }
                    i++;
                }
                return factors;
         }

    public static long TriangleNumber(long n)
        {
            return n * (n + 1) / 2;
        }
 }