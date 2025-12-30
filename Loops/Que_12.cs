using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Que_12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("print prime numbers between 1-100");
            for(int i=1;i<=100;i++)
            {
                if(i%2==0 || i%3==0 || i%5==0 || i%7==0)
                {

                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
