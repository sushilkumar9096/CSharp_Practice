using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Que_3
    {
        static void Main(string[] args)
        {
            //print sum of numbers from 1=n;
            int num=int .Parse(Console.ReadLine());
            int sum = 0;
            for (int i=1;i<=num;i++)
            {
                
                sum = sum + i;
                
            }
            Console.WriteLine("sum 0f numbers from 1 to " + num + " =" + sum);
        }
    }
}
