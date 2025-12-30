using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_on_if_else
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //check number is positive negatiive or zero
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
                Console.WriteLine(num + " _is positive");
            else if (num < 0)
                Console.WriteLine(num + "_is Negative");

            else
                Console.WriteLine(num + "_is Zero");
        }
    }
}
