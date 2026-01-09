using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Value_Reference_Type
{
    class Employeee
    {
               public int sallary;
        public int Age;
    }
    internal class Class
    {
        static void Main(string[] args)
        {
            Employeee ee = new Employeee();
            ee.sallary = 50000;
            ee.Age = 23;
            Employeee e1 = ee;
            Employeee e2 = ee;
            ee.Age = 25;
            Console.WriteLine($"e1.age :- {e1.Age}\t e2.Age:- {e2.Age}");

        }
    }
}
