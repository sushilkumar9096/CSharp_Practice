using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Que_9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pRINT NUMBER BETNWEEN 1-100 skip multiples of 3");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }   
        }
    }
}
