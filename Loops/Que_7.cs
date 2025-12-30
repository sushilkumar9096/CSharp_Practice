using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Que_7
    {
        static void Main(string[] args)
        {
            //Count number of digits in a number
            Console.WriteLine("Enter a number ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while(num>0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
