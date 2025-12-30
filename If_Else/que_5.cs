using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_on_if_else
{
    internal class que_5
    {
        static void Main(string[] args)
        {
            // print grades 
            Console.Write("enter mark :");
            int mark =int.Parse(Console.ReadLine());
            if (mark >= 90)
                Console.WriteLine("A grade");
            else if (mark >= 75)
                Console.WriteLine("B Grade");
            else if (mark >= 50)
                Console.WriteLine("C Grade");
            else Console.WriteLine("Fail");
        }
    }
}
