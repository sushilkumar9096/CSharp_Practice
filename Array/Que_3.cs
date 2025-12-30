using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Array
{
    internal class Que_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" find maximum and minimum \n enter size of an array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter data at location : {i + 1}");
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }
            int max = arr[0], min = arr[0];
            foreach(int items in arr)
            {
                if (items > max  )
                {
                    max = items;
                   
                }
                if (items < min)
                {
                    min = items;
                }
            }
            Console.WriteLine($"max = {max} :  min = {min}");
        }
    }
}
