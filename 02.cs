using System;
using System.Collections.Generic;
using System.IO;
//using Timer;

class Solution {
    /*
    static long Fibonacci(int n)
        {
            if (n == 1 || n == 0)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        */
    static void Main(String[] args) {
        
        int T = Int32.Parse(Console.ReadLine());
        for(int j = 0; j < T; j++){
            int N = Int32.Parse(Console.ReadLine());
            
            long fib = 2;
            long lastFib = 1;
            long sum = 0;
            
            //SimpleTimer.Start();
            while (fib < N)
            {
                if (fib % 2 == 0)
                {
                    sum += fib;
                }

                fib += lastFib;

                lastFib = fib - lastFib;
            }
            //SimpleTimer.Stop();
            
            //Console.WriteLine(SimpleTimer.ToString());

            Console.WriteLine(sum);
            }
    }
}