using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
        {
        int T = Int32.Parse(Console.ReadLine());
        for (int j = 0; j < T; j++)
            {
            int num = Int32.Parse(Console.ReadLine());
            string total = "";
                if (num >= 1000)
                {
                    total += Words(1) + Words(1000);
                    num -= 1000;
                }
                if (num >= 100)
                {
                    total += Words(num / 100) + Words(100);
                    num -= (num / 100) * 100;
                    //if (num > 0)
                    //    total += "and"; // and
                }
                if (num >= 20)
                {
                    total += Words(num - (num % 10));
                    total += Words(num % 10);
                }
                else
                {
                    total += Words(num);
                }
            Console.WriteLine(total);
        }
    }
    
    static string Words(int number)
        {
            switch (number)
            {
                case 1: return "One"; ; // one
                case 2: return "Two"; // two
                case 3: return "Three"; // three
                case 4: return "Four"; // four
                case 5: return "Five"; // five
                case 6: return "Six"; // six
                case 7: return "Seven"; // seven
                case 8: return "Eight"; // eight
                case 9: return "Nine"; // nine
                case 10: return "Ten"; // ten
                case 11: return "Eleven"; // eleven
                case 12: return "Twelve";// twelve
                case 13: return "Thirteen";// thirteen
                case 14: return "Fourteen";// fourteen
                case 15: return "Fifteen";// fifteen
                case 16: return "Sixteen"; // sixteen
                case 17: return "Seventeen"; // seventeen
                case 18: return "Eighteen";// eighteen
                case 19: return "Nineteen";// nineteen
                case 20: return "Twenty";// twenty
                case 30: return "Thirty";// thirty
                case 40: return "Forty";// forty
                case 50: return "Fifty"; // fifty
                case 60: return "Sixty";// sixty
                case 70: return "Seventy";// seventy
                case 80: return "Eighty";// eighty
                case 90: return "Ninety";// ninety
                case 100: return "Hundred"; // hundred
                case 1000: return "Thousand"; // thousand
            }
           return "";
        }
}