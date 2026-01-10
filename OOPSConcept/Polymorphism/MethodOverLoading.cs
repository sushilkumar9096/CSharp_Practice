using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPSConcept.Polymorphism
{
    internal class MethodOverLoading
    {
        public void Add()
        {
            int a = 20, b = 30, c = a + b;
            Console.WriteLine("c = "+c);
        }
        public void Add(int a,int b)
        {
           int  c = a + b;
            Console.WriteLine("c = " + c);
        }
        public void Add(string a,string b)
        {
          string c = a + b;
            Console.WriteLine("c = " + c);
        }
        public void Add(float a,float b)
        {
                       float c = a + b;
            Console.WriteLine("c = " + c);
        }

        static void Main(string[] args)
        {
            MethodOverLoading mo = new MethodOverLoading();
           mo.Add("sushil", "kuchame");
            mo.Add(40, 50);
            mo.Add(1.2f, 2.3f);

        }
    }
}
