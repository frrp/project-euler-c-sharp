using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Diagnostics;

class Solution 
{
    static bool isPrime(int n)
    { 
        if (n%2==0 || n%3==0)
            return false;
        int b = (int)Math.Sqrt(n);
        for (int i=1; (6*i-1)<=b; i++)
        {
            if (n%(6*i-1)==0)
                return false;
            if (n%(6*i+1)==0)
                return false;
        }
        return true;
    }
    
    static public IEnumerable<string> permute(string word)
    {
        if (word.Length > 1)
        {
            char character = word[0];
            foreach (string subPermute in permute(word.Substring(1)))
            {
                for (int index = 0; index <= subPermute.Length; index++)
                {
                    string pre = subPermute.Substring(0, index);
                    string post = subPermute.Substring(index);

                    if (post.Contains(character))
                            continue;                       

                    yield return pre + character + post;
                }
            }
        }
        else
        {
            yield return word;
        }
    }
    
    static SortedSet<int> pandigitalCandidates = new SortedSet<int>();
    
    static void Main(string[] args)
    {
        /*
        Only 4 and 7-digit pandigital numbers can be primes, others are divisible by 3.
        */
        // first generate the sorted set of all (4!+7!) candidate permutations
        foreach (string s in permute("1234"))
            pandigitalCandidates.Add(int.Parse(s));
        foreach (string s in permute("1234567"))
            pandigitalCandidates.Add(int.Parse(s));

        int T = Int32.Parse(Console.ReadLine());
        for (int z = 0; z < T; z++)
            {
            int N = Int32.Parse(Console.ReadLine());
            //Stopwatch clock = Stopwatch.StartNew();
            if (N < 1423) // the smallest candidate is 1423
                Console.WriteLine(-1);
            else
                {
                //if (N < 1234567)
                //    bound = 23; // there are 24 permutations of 1234

                foreach (int candidate in pandigitalCandidates.Reverse())
                    {
                        if (candidate > N)
                            continue;
                        if (isPrime(candidate))
                        {
                            Console.WriteLine(candidate);
                            //clock.Stop();
                            //Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
                            break;
                            }
                    }
                 }
            }
    }
}