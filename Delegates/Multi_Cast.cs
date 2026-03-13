using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegates
{
    public delegate void Calculation4(int a, int b);   
    internal class Multi_Cast
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine($"The result of Addtion {a + b}");
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"The result of Subtraction {a - b}");
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"The result of Multiplication {a * b}");
        }   
        static void Main(string[] args)
        {
            Calculation4 obj = new Calculation4(Add);
            obj+= Subtract;
            obj+= Multiply;
            obj.Invoke(50, 30);

        }
    }
}
