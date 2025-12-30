using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Que_8
    {
        static void Main(string[] args)
        {
            //print fibonaci series up to n numbers 
            Console.WriteLine("Enter a number ");
            int num = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            Console.WriteLine(a + " ");
            for (int i=1;i<=num;i++)
            {
               
                int next = a + b;
                a = b;
                b = next;
                Console.WriteLine(next);
            }
        }
    }
}
