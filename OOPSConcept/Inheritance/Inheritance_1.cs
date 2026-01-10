using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPSConcept.Inheritance
{
    class VisitingEmployee : Employee
    {
        public int VisitingSalary;
        public int VisitingHours;
    }
    class PermentEmployee : Employee
    {
        public int PermanentSalary;
        public int PermanentHours;
    }
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int ConntactNo;

       public void show()
        {
                        Console.WriteLine("Employee Details");
        }
    }
    
    internal class Inheritance_1
    {
        static void Main(string[] args)
        {
            PermentEmployee Asad = new PermentEmployee();
            Asad.EmpId = 12;
            VisitingEmployee Ali = new VisitingEmployee();
            Ali.EmpId = 13;
            Console.WriteLine($"Asad ID ={Asad.EmpId}\t  Ali Id = {Ali.EmpId}");

        }
    }
}
