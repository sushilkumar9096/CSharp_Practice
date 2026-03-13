using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegates
{
    public delegate void show_Delegate();
    public delegate void Calculation2(int num);
    internal class Multiple_DeleGates
    {
        public static void show()
        {
            Console.WriteLine("This is a show method");
        }
        public static void Square(int num)
        {
            Console.WriteLine($"The square of {num} is {num * num}");
        }
        public static void Cube(int num)
        {
            Console.WriteLine($" The cube of {num} is {num * num * num}");
        }
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
        public static void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"The result of Division {a / b}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Add);
            obj.Invoke(10, 5);
            obj = Subtract;
            obj(20, 10);
            obj = Multiply;
            obj(5, 4);
            obj = Divide;
            obj(15, 3);
            Calculation2 obj2 = new Calculation2(Square);
            obj2.Invoke(6);
            obj2= Cube;
            obj2.Invoke(6);
            show_Delegate obj3 = new show_Delegate(show);   
            obj3.Invoke();
        }
    }
}
