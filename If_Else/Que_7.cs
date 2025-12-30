using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_on_if_else
{
    internal class Que_7
    {
        static void Main(string[] args)
        {
            char ch = char.ToLower(Console.ReadLine()[0]);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine(ch + " _is vowel");
            else
                Console.WriteLine(ch + " Is  not vowel");
        }
    }
}
