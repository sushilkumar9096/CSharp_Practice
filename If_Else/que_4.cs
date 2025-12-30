using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_on_if_else
{
    internal class que_4
    {
        static void Main(string[] args)
        {
                int num1=int.Parse(Console.ReadLine());
                int num2=int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int largest = num1;
            if (num2 > largest)
            {
                largest = num2;
            }
            else if (num3 > largest)
            {
                largest = num3;
            }
            Console.WriteLine(largest + "_is largest number");

        }
    }
}
