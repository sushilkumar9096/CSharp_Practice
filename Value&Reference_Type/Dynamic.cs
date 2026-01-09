using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Value_Reference_Type
{
    internal class Dynamic
    {
        public static void  Show(dynamic c)// we cannot use int type 
        {
            Console.WriteLine(c);
        }
        public static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        
        static void Main(string[] args)
        {
            dynamic d;// initialize dynamic variable
            d = 10;
            Console.WriteLine($"d = {d} \t {d.GetType()}");
            d = "Sushilk";// dynamic variable can hold any type of data
            Console.WriteLine($"d= {d} \t {d.GetType()}");
            Dynamic.Show(100);
            Dynamic.Show("Sushil Kumar");
            Dynamic.Show(12.34);
            Dynamic.Show(true);
        }
    }
}
