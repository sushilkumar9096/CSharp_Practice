using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPSConcept.Inheritance
{
    class BaseClass
    {
        public  void Display1()
        {
            Console.WriteLine("Base Class Method");
        }
    }
    class DerivedClass1 : BaseClass
    {
        public void Display2()
        {
            Console.WriteLine("Derived Class Method");
        }
    }
    class DerivedClass2 : DerivedClass1
    {
        public void Display3()
        {
            Console.WriteLine("Derived Class 2 Method");
        }
    }
    internal class TypesOf_Inheritance
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
            b.Display1();
            DerivedClass1 d1 = new DerivedClass1();
            d1.Display2();
            d1.Display1();
            DerivedClass2 d2 = new DerivedClass2();
            d2.Display3();
            d2.Display2();
            d2.Display1(); 
        }
    }
}
