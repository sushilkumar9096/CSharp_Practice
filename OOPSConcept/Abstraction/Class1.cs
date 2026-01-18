using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPSConcept.Abstraction
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay; // 25000 /// house rent -- 5000,convence allowence -4000
        double TxzDeduction = 0.1;
        double netsalary;
        public  Employee(int Eid,string Ename, double Egrosspay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = Egrosspay;
        }
        void CalculateSalary()
        {
            if(GrossPay >=30000)
            {
                netsalary = GrossPay - (TxzDeduction *    GrossPay );
                Console.WriteLine("Your Salary is : {0}", netsalary);
            }
            else
            {
                Console.WriteLine("Your Salary is : {0}", GrossPay);
            }
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee ID: {0}", EmpId);
            Console.WriteLine("Employee Name: {0}", EmpName);
            this.CalculateSalary();
        }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(12,"Sushil",40000);
            e.ShowEmployeeDetails();
        }
    }
}
