using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Constructor
{
    class Example
    {
        string name;
        int age;
        public Example(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void getData()
        {
            Console.WriteLine($"Name is : {name}\n age is : {age}");
        }
        public Example(Example e)// Copy Constructor
        {
            this.name = e.name;
            this.age = e.age;
        }

    }
    internal class Copy_Constructor
    {
        
        static void Main(string[] args)
        {
            Example obj= new Example("Sushil",22);
            obj.getData();
            Example obj1 =new Example(obj); // Copy Constructor
            obj1.getData();
        }
    }
}
