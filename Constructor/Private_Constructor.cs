using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Constructor
{
    class Example1
    {
        public static int a;
        public string name;
        public string fname;
        public Example1(string name, string fname)
        {
            this.name= name;
            this.fname = fname;
            Console.WriteLine($"Name is ;- {name} \n seconf name is {fname}");
        }
        private Example1()
        {

        }
        public static int getIncrement()
        {
            return ++a; 
        }
        public static void getTime()
        {
                        Console.WriteLine(DateTime.Now);
        }
    }
    
    internal class Private_Constructor
    {
        static void Main(string[] args)
        {
            Example1 e = new Example1("sushil","Adi");   
            Example1.getTime();
            Example1.a = 20;
            Console.WriteLine(Example1.getIncrement());
            
        }
    }
}
