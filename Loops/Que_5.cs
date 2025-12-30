using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Que_5
    {
        static void Main(string[] args)
        {
            //print all evan numbers between 1 to 50
            Console.WriteLine("even numbers between 1- 50");
            for (int i=1;i<=50;i++)
            {
                if(i%2 ==0)
                {
                   
                    Console.WriteLine(i);
                }
            }
        }
    }
}
