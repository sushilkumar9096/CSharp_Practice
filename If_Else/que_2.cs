using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_on_if_else
{
    internal class que_2
    {
        static void Main(string[] args)
        {
                int age=int.Parse(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("person is adult");
            else if (age < 18 && age > 0)
                Console.WriteLine("person is minor");
            else Console.WriteLine("something wrong ");
        }
    }
}
