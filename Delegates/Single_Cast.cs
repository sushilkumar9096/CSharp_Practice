using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegates
{
    public delegate void Calculation3(int num1, int num2);
    internal class Single_Cast
    {
        public static void Addition(int num1 , int num2)
        {
            Console.WriteLine($"The result of Addition {num1 + num2}");
        }
        static void Main(string[] args)
        {
            Calculation3 obj3 = new Calculation3(Addition);
            obj3.Invoke(20,30);
        }
    }
}
