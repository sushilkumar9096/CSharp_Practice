using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Que_4
    {
        static void Main(string[] args)
        {
            //print factorial of a number using loop
                        Console.WriteLine("Enter a number to find factorial:");
            int num = int.Parse(Console.ReadLine());
            long factorial = 1;  // Use long for larger factorials

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {num} is: {factorial}");
        }
    }
}
