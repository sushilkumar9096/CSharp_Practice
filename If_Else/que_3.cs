using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_on_if_else
{
    internal class que_3
    {
        static void Main(string[] args)
        {
                int num=int.Parse(Console.ReadLine());
            
            if (num % 2 == 0)
                Console.WriteLine(num + "-is even");
            else if (num % 2 == 1)
                Console.WriteLine(num + "_is odd");
            else Console.WriteLine("wrong input");

        }
    }
}
