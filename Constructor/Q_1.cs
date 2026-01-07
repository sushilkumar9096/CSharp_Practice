using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Constructor
{
    internal class Q_1
    {
        int EmpId;
        string EmpName;
        int EmpAge;
        public Q_1(int EmpId,string EmpName,int EmpAge)
        {
            Console.WriteLine("This is a default constructor.");
           this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
            Console.WriteLine($"EmpId :- {EmpId}  EmpName :- {EmpName} EmpAge :- {EmpAge}");
        }
        public int getId()
        {
            return this.EmpId;
        }
        public string getName()
        {
              return this.EmpName;
        }
        public int getAge()
        {
            return this.EmpAge;
        }
        static void Main(string[] args)
        {
            Q_1 Ali = new Q_1(11,"Ali Khan",22);
            Q_1 Ahmad = new Q_1(12,"Ahmad Khan",25);
            Console.WriteLine("Employee Id is {0}",Ali.getId());
            Console.WriteLine("Employee Name is {0}", Ahmad.getName());
            Console.WriteLine("Employee Age is {0}", Ali.getAge());
            Console.WriteLine("Employee Id is {0}", Ahmad.getId()); 
            Console.WriteLine("Employee Name is {0}", Ahmad.getName());
            Console.WriteLine("Employee Age is {0}",Ahmad.getAge());
        }
    }
}
