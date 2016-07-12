using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
        static SortedSet<string> names = new SortedSet<string>();

        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            for (int j = 0; j < N; j++)
            {
                names.Add(Console.ReadLine());
            }
            int Q = Int32.Parse(Console.ReadLine());
            for (int j = 0; j < Q; j++)
            {
                string query = Console.ReadLine();
                if (!names.Contains(query))
                    {
                    Console.WriteLine("wrong query!");
                    break;
                    }
                int totalScore = GetNameScore(query) * GetNamePosition(query);
                
                Console.WriteLine(totalScore);
            }
        }

        static int GetNamePosition(string name)
        {
                int i = 0;
                foreach (string n in names)
                    {
                    i++;
                    if (n == name)
                        return i;
                    }
                return 0;
        }
    
        static int GetNameScore(string name)
        {
            int score = 0;
            foreach (char c in name)
            {
                score += (int)c - (int)'A' + 1;
            }
            return score;
        }
    
}