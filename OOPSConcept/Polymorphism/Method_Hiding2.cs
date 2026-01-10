using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPSConcept.Polymorphism
{
    class employee
    {
        public string firstname;
        public string lastname;
      public void PrinFullTime()
        {
            Console.WriteLine("Adil " + "khan " +"P");
        }
        
    }
    class partTimeEmployee : employee
    {
   public new void PrinFullTime()
        {
            Console.WriteLine(firstname +" "+ lastname +"PPe");
        }   
    }
    class fullTimeEmployee : employee
    {
        public new void PrinFullTime()
        {
            Console.WriteLine(firstname + " " + lastname + "FFe");
        }
    }
    internal class Method_Hiding2
    {
        static void Main(string[] args)
        {
             partTimeEmployee pte = new partTimeEmployee();
            pte.firstname = "Sushil";
            pte.lastname = "Kuchame";
            pte.PrinFullTime();
        }
    }
}
