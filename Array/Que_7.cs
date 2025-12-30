using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Array
{
    internal class Que_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que - search an element in an array  ");
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            
            foreach(int items in arr )
            {
                Console.Write($" {items} ");
            }
            Console.WriteLine("enter element to search ");
            int search = int.Parse(Console.ReadLine());
            bool found = false ;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == search)
                {
                    Console.WriteLine($"Element {search} found in array at {i} index ");
                    found = true;
                }
            }
            if(!found)
            {
                Console.WriteLine($"Element {search} not found in array ");
            }
        }
    }
}
