using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Value_Reference_Type
{
    internal class PassByValue
    {
        public static void PassByValuee(int a)
        {
            a = a + 10;
            Console.WriteLine($"Value inside the method: {a}");
        }
        static void Main(string[] args)
        {
            int value = 50;
            PassByValuee(value);//60
            Console.WriteLine($"valueof ouside  : {value}");//50 
        }
    }
}
