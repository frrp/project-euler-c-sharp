using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
    
class Solution 
{
    static void Main(string[] args)
    {
        int T = Int32.Parse(Console.ReadLine());
        for (int j = 0; j < T; j++)
            {
            int N = Int32.Parse(Console.ReadLine());
            Dictionary<int, int> lengths = new Dictionary<int, int>();
            for (int i = 2; i <= N-1; i++)
                lengths.Add(i, RecurLen(i));
                
            var iWithMaxRecur = lengths.FirstOrDefault(x => x.Value == lengths.Values.Max()).Key;
            
            Console.WriteLine(iWithMaxRecur);
            }
    }
    
    static int RecurLen(int n) // digits for unit fraction 1/n
            {
            int r = 10; // initial remainder (10/n)/10
            Dictionary<int, int> seen = new Dictionary<int, int>(); // remainder -> first pos
            int i = 0;
            while (true)
                {
                if (r == 0) 
                    return 0;  // divides evenly.
                if (seen.ContainsKey(r)) 
                    return i-seen[r]; // curpos - firstpos
                seen.Add(r, i);
                r = 10*(r % n);
                i++;
            }
      }
}
