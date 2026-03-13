using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Generics
{
    class Example
    {
        public static void ShowArray<T>(T[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine( arr[i] );
            }
        }
        public static void Check1<T>(T a)
        {
            Console.WriteLine(typeof(T));
        }   

        public static bool Check<T>(T a , T b)
        {
            bool c = a.Equals(b);
            return c;
        }
      
    }
    internal class Ex_1
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 10;
            Numbers[1] = 20;
            Numbers[2] = 30;

            string[] Names = {"Sushil", "Rohit", "Satyarth"};
            Example.ShowArray(Numbers);
            Example.ShowArray(Names);
            Console.WriteLine(Example.Check(10, 20));
            Example.Check1("sushil");

        }
    }
}
 