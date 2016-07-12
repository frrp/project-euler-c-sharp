using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int T = Int32.Parse(Console.ReadLine());
        for(int j = 0; j < T; j++){
            int num = Int32.Parse(Console.ReadLine());
                          
            long three=(num-1)/3;
            long five=(num-1)/5;
            long fifteen=(num-1)/15;
            long sum = 3*(three*(three+1)/2)+5*(five*(five+1)/2)-15*(fifteen*(fifteen+1)/2);

       	Console.WriteLine(sum);
        }
    }
}
