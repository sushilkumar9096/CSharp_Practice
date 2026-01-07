using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Constructor
{
    class BaseClass
    {
        public BaseClass(string message)
        {
            Console.WriteLine($"BaseClass Constructor :-{message}");
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass() :base("Hello C#")
        {
            Console.WriteLine("DerivedClass Constructor");
        }
    }

    internal class Constructor_In_Inheritance
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();

            
        }
    }
}
