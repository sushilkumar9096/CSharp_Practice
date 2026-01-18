using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interface
{
    interface IEmployee
    {
        void show();
    }
    public class  IEmpoloyees : IEmployee
    {
        public void show()
        {
            Console.WriteLine("This is FullTime Employee");
        }
    }
    
     
    interface IAnimal
    {
        void Sound();
    }   
    class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    internal class Interface_1
    {
        static void Main(string[] args)
        {
           Dog d = new Dog();   
            d.Sound();
            IEmpoloyees emp = new IEmpoloyees();    
            emp .show();
        }
    }
}
