using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Array
{
    internal class Que_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que: Find sun of array elemnets \n enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i=0;i<size;i++)
            {
                Console.WriteLine($"Enter data at location : {i+1}");
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }
            int sum = 0;
            foreach(int items in arr)
            {
                sum = sum + items;
            }
            Console.WriteLine("Sum of array elements ="+sum);
        }
    }
}
