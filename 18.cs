using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
     static void Main(string[] args)
        {
            List<List<int>> lists = new List<List<int>>();
            int T = Int32.Parse(Console.ReadLine());
            for (int w = 0; w < T; w++)
            {
                int N = Int32.Parse(Console.ReadLine());
                for (int z = 0; z < N; z++)
                {
                    string[] nums = Console.ReadLine().Split(' ');
                    List<int> list = new List<int>();

                    foreach (string s in nums)
                        list.Add(int.Parse(s));
                    lists.Add(list);
                }

                for (int i = lists.Count - 2; i >= 0; i--)
                {
                    for (int j = 0; j < lists[i].Count; j++)
                        lists[i][j] += Math.Max(lists[i + 1][j], lists[i + 1][j + 1]);
                }
                Console.WriteLine(lists[0][0]);
            }
        }
}