using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Array
{
    internal class Que_6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("QUe = Print array elements in reverse \n enter size of an array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int[]arr2=new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter data at location : {i + 1}");
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }
            Console.WriteLine("Array elements in reverse order");

            for(int i = 0;i < size;i++)
            {
                Console.WriteLine($" arr2 = {arr2[i] = arr[i]}");
                
            }
           
        }
    }
}
