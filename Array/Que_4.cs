using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Array
{
    internal class Que_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count how many numbers are even in array \n enter size of an array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i=0;i<size;i++)
            {
                Console.WriteLine($"Enter data at location{i+1}");
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }
            int count = 0;
            foreach(int items in arr)
            {
                if(items % 2==0)
                {
                    count++;
                    Console.WriteLine($"{items} ");
                }
               
            }
            Console.WriteLine($"there are {count} even numbers in array");
        }
    }
}
