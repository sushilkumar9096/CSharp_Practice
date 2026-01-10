using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPSConcept.Polymorphism
{
    internal class Method_Hiding
    {
        class parent
        {
            public void show()
            {
                Console.WriteLine("parent class method");
            }
        }
        class child : parent
        {
            public  new void show()
            {
                Console.WriteLine("child class method");
            }
        }
         class  child2 : parent 
        {
            public void show()
                {
                base.show();
            }
        }
        static void Main(string[] args)
        {
            child c = new child();
            c.show(); //child class method
            ((parent)c) .show();//parent class method
            child2 c2 = new child2();
            c2.show();//parent class method
        }
    }
}
