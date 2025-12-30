using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_on_if_else
{
    internal class Que_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a year");
            int year = int.Parse(Console.ReadLine());
            if  ((year %4==0 && year%100!=0) || (year % 400 == 0))
            {
                Console.WriteLine(year + "_ is leap year");
            }
            else
            {
                Console.WriteLine(year + "_is not lep year");
            }
        }
    }
}
