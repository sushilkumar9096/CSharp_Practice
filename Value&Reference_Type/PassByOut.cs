using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Value_Reference_Type
{
    internal class PassByOut
    {
        public static void PassByOutMethod(out int number)
        {
            number = 20;
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            int value;
                        PassByOutMethod(out value);//20
            Console.WriteLine(value);
            
           
        }
    }
}
