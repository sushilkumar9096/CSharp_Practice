using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Constructor
{
    class person
    {
       public static string PersonName = "Sushil";
        public static int PersonAge = 23;
         static person()
         {
            PersonName = "Sushil";
            PersonAge = 23;
            Console.WriteLine("Static constructor invoked !!");

         }
        public person()
        {
            Console.WriteLine("Default Constructor invoked !!");
        }
        public void GetDetails()
        {
            Console.WriteLine($"Person name is :-{PersonName} \nPerson age is :- {PersonAge}");

        }
    }
    class Program
    {

    }
    internal class Static_Constructor
    {
        static void Main(string[] args)
        {
            person umar =new person();
            umar.GetDetails();
        }
    }
}
