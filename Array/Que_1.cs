using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Array
{
    internal class Que_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUe:  read 5 numbers in an array print all elements");
            Console.WriteLine("enter size of an  array ");
            int num = int.Parse(Console.ReadLine());
            int[] arr =new int[num];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"Enter data{i+1} ");
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
               
            }
            foreach(int items in arr)
            {
                Console.Write($" {items} ");
            }
        }
    }
}
