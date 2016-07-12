using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    //  can be improved using the Zeller's congruence
    static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());
            for (int w = 0; w < T; w++)
            {
                string[] a = Console.ReadLine().Split(' ');
                string[] b = Console.ReadLine().Split(' ');
                
            DateTime date = new DateTime(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]));
            DateTime lastDay = new DateTime(int.Parse(b[0]), int.Parse(b[1]), int.Parse(b[2]));

            int counter = 0;

            while (date != lastDay)
            {
                if (date.Day == 1 && date.DayOfWeek == DayOfWeek.Sunday)
                    counter++;
                date = date.AddDays(1);
            }
           Console.WriteLine(counter);
        }
    }
}