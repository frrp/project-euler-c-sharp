using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long N = Convert.ToInt32(input[0]); // < 2*10^14
            int a = Convert.ToInt32(input[1]);

            List<long> triangles = new List<long>();
            List<long> pentagons = new List<long>();
            List<long> hexagons = new List<long>();

            for (long i = 1; i < (int)Math.Sqrt(N); i++)
            {
                triangles.Add(Triangle(i));
                pentagons.Add(Pentagonal(i));
                hexagons.Add(Hexagonal(i));
            }

            foreach(long i in pentagons)
                if (a == 3)
                    if (triangles.Contains(i))
                        Console.WriteLine(i);
                else
                    if (hexagons.Contains(i))
                        Console.WriteLine(i);
        }

        static long Triangle(long number)
        {
            return number * (number + 1) / 2;
        }
    
        static long Pentagonal(long number)
        {
            return number * (3 * number - 1) / 2;
        }
        
        static long Hexagonal(long number)
        {
            return number * (2 * number - 1);
        }
}