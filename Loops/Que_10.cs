using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Que_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check weather number is pallindrom or not \n Enter anumber ");
            int num = int.Parse(Console.ReadLine());    
            int originalNum = num;
            int reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            if(originalNum == reverse)
            {
                Console.WriteLine($"{originalNum} is a palindrome number.");
            }
            else
            {
                Console.WriteLine($"{originalNum} is not a palindrome number.");
            }
        }
    }
}
