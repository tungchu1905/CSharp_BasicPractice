using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3.OOP.Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}
