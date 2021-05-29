using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_in_Csharp_Exercise
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(int n)
        {
            age = n;
        }
    }
}
