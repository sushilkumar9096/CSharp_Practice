using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Constructor
{
    internal class Constructor_Overloading
    {
        public Constructor_Overloading() {
            Console.WriteLine("This is default Constructor");
        }
        public Constructor_Overloading(int a, int b)
        {
            Console.WriteLine($"This is second  constructor : {a+b}");
        }
        public Constructor_Overloading(int a,int b,int c)
        {
            Console.WriteLine($"This is third construtor {a+b+c}");
        }
        static void Main(string[] args)
        {
            Constructor_Overloading C = new Constructor_Overloading(2, 3);
        }
    }
}
