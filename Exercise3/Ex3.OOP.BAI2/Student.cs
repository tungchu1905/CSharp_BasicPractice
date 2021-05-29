using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3.OOP.BAI2
{
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} year old",age);
        }
    }
}
