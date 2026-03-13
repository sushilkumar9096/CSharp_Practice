using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Generics
{
    class Examplee<T>
    {
        T box;
        public T Box
        {
            set { this.box = value; }
            get { return this.box; }
        }
        //public Examplee(T b)
        //{
        //    this.box = b;
        //}
        //public T getBox()
        //{
        //    return this.box;
        //}
    }
    internal class Generic_Class
    {
        static void Main(string[] args)
        {

            Examplee<int> e = new Examplee<int>();
            e.Box = 20;
            Console.WriteLine(e.Box);
            Examplee<string> e1 = new Examplee<string>();
            e1.Box = "sushil";
            Console.WriteLine(e1.Box);

            //Examplee<int> e = new Examplee<int>(20);
            //Examplee<string> e1 = new Examplee<string>("Hello World");
            //Examplee<char> e2 = new Examplee<char>('A');
            //Console.WriteLine(e.getBox());
            //Console.WriteLine(e2.getBox());
            //Console.WriteLine(e1.getBox());


        }
    }
}
