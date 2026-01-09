using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Value_Reference_Type
{
    internal class Var
    {
        public static int  Show(int a,int b)//cannot use var as a parameters 
        {
            return 0;
        }
        static void Main(string[] args)
        {
            var b = "Sushil";
            Console.WriteLine(b.ToUpper());
            Console.WriteLine(b.ToLower());
            Console.WriteLine(b.GetType());
        }
    }
}
