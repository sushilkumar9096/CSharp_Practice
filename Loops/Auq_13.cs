using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_On_Loops
{
    internal class Auq_13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("greates of divisorof two numbers \n enter two numbers ");
                int num1 = int.Parse(Console.ReadLine());
                  int num2 = int.Parse(Console.ReadLine());
            int gcd = 1;
            for(int i=1;i<=num1 && i<=num2;i++)
            {
                if(num1%i==0 && num2%i==0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine(gcd);
        }
    }
}
