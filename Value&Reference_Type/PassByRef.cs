using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Value_Reference_Type
{
    internal class PassByRef
    {
        public static void PassByReference(ref int a)
        {
            a = a + 10;
            Console.WriteLine($"Value inside the method: {a}");
        }
        static void Main(string[] args)
        {
            int value = 5;
            PassByReference(ref value);//15 
            Console.WriteLine(value);
        }
    }
}
