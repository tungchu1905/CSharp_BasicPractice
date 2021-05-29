using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_in_Csharp_Exercise
{
    class Student : Person
    {
       public void Study()
        {
            Console.WriteLine("I'm Studying Code C#");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0}: ",age);
        }
    }
}
