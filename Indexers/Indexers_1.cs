using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Indexers
{
    class Employeeee
    {
        private int[] Age = new int[3];

        public int this[int index]
        {
            get { return Age[index]; }
            set 
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value > 0)
                        Age[index] = value;
                    else
                        Console.WriteLine("Age must be a positive value.");
                }   
                else
                {
                    Console.WriteLine("Index out of range.");
                }
            }
        }
    }

    internal class Indexers_1
    {
        static void Main()
        {
            Employeeee emp = new Employeeee();

            emp[0] = Convert.ToInt32(Console.ReadLine());
            emp[1] = 30;
            emp[2] = 35;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(emp[i]);
            }
        }
    }
}