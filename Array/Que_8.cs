using System;

namespace Practice.Array
{
    internal class Que_8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the second largest in array");
            int[] arr = { 10, 20, 5, 30, 25, 40, 50, 15 };

            foreach (int item in arr)
                Console.Write($" {item} ");

            int largest = arr[0];
            int secondLargest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }

            Console.WriteLine($"\nLargest: {largest}");
            Console.WriteLine($"Second Largest: {secondLargest}");
        }
    }
}
