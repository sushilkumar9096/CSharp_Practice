using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Value_Reference_Type
{
    struct Employee
    {
        public int sallary;
        public int Age;
    }
    internal class Struct
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.sallary = 50000;
            e.Age = 23;
            Employee e1 = e;
            Employee e2 = e1;
            e.Age = 25;
            Console.WriteLine($"e1.age :- {e1.Age}\t e2.Age:- {e2.Age}");
        }
    }
}
