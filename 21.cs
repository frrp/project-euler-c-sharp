using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static Dictionary<int, int> sumOfDivisors = new Dictionary<int, int>();

    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        for (int j = 0; j < T; j++)
            {
            int N = Int32.Parse(Console.ReadLine());
        
            int amicableSum = 0;
            
            for (int i = 2; i <= N; i++)
            {
                sumOfDivisors.Add(i, GetSumOfDivisors(i));
            }

            foreach (int num1 in sumOfDivisors.Keys)
            {
                if (sumOfDivisors.ContainsKey(sumOfDivisors[num1]) && IsAmicable(num1, sumOfDivisors[num1]))
                    amicableSum += num1;
            }
            Console.WriteLine(amicableSum);
            }    
    }
    
    static bool IsAmicable(int num1, int num2)
        {
            if (sumOfDivisors[num1] == num2 && sumOfDivisors[num2] == num1 && num1!=num2)
                return true;
            
            return false;
        }

    static int GetSumOfDivisors(int num)
        {
            List<int> factors = new List<int>();
            int n = num;

            factors.Add(1);

            int i = 2;
            while (n != 1 && i < (int)Math.Sqrt(num))
            {
                if (num % i == 0)
                {
                    n = num / i;
                    if (!factors.Contains(n))
                        factors.Add(n);
                    if (!factors.Contains(i))
                        factors.Add(i);
                }
                i++;
            }
            return factors.Sum();
        }
        
}