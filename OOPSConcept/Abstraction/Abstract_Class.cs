using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPSConcept.Abstraction
{
    abstract class person
    {
        public string Firstname;
                public string Lastname;
        public string name;
        public int age;
        public long phoneNumber;
       public abstract void PrintDetails();
    }
    class student : person
    {
        public int RollNo;
        public string Fees;
        public override void PrintDetails()
        {
            string name = this.Firstname + " " + this.Lastname;
            Console.WriteLine("Student Name is : {0}",name);
            Console.WriteLine("Student Age is : {0}", this.age);
            Console.WriteLine("Student RollNo is : {0}", this.RollNo);
            Console.WriteLine("Student Fees  is : {0}", this.Fees);
            Console.WriteLine("Student Phonenumber is :{0}",phoneNumber);

        }
    }
    class teacher : person
    {
        public string qualification;
        public int salary;
        public override void PrintDetails()
        {
            string name = this.Firstname + " " + this.Lastname;
            Console.WriteLine("Teachers Name is : {0}", name);
            Console.WriteLine("Teachers Age is : {0}", this.age);
            Console.WriteLine("teachers Phonenumber is :{0}", phoneNumber);
            Console.WriteLine("Teachers  Qualifitcionis :{0}", qualification);
            Console.WriteLine("Teachers  salalry i s: {0}",salary);

        }
    }

    internal class Abstract_Class
    {
        static  void Main(string[] args)
        {
            student s = new student();
            s.Firstname = "John";
            s.Lastname = "Doe";
            s.age = 20;
            s.RollNo = 101;
            s.phoneNumber = 1234567890;
            s.Fees = "5000";
            s.PrintDetails();
            Console.WriteLine("------------------------------");
            teacher t = new teacher();
            t.Firstname = "Jane";
            t.Lastname = "Smith";
            t.age = 35;
            t.phoneNumber = 9876543210;
            t.qualification = "MSc Education";
            t.salary = 60000;
            t.PrintDetails();


        }

    }
}
