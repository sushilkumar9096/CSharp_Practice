using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPSConcept.Polymorphism
{
    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("This is a method of parent class");
        }

    }
    class child : parent
    {
        public override void print()
        {
            Console.WriteLine("This is a method of child class");
        }
    }

    internal class Method_OverRiding
    {
        static void Main(string[] args)
        {
            
            child c =new child();   
            c.print();
            parent p = new child();
            p.print();
        }
    }
}
