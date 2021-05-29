using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3.OOP.BAI2
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
}
