using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Que_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum of digts of number\n enter number ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while(num>0)
            {
                int remainder = num % 10;
                sum=sum + remainder;
                num=num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
