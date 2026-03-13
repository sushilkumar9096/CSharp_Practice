using System;
using System.Runtime.CompilerServices;

public delegate void Calculation(int a, int b);
public class Vmsfr4a3
{
    public static void Add(int a, int b)
    {
         
        Console.WriteLine($"The result of Addtion {a + b}");
    }
    public static void Subtract(int a, int b)
    {
        Console.WriteLine($"The result of Subtraction {a - b}");
    }
    public static void Multiply(int a, int b)
    {
        Console.WriteLine($"The result of Multiplication {a * b}");
    }
    public static void Divide(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine($"The result of Division {a / b}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
    static void Main(string[] args)
    {
        Calculation obj = new Calculation(Add);
        obj.Invoke(10, 5);
    }
}
