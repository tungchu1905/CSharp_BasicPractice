using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._7
{
    class ex7
    {
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 % 2 == 0 ? "A is positive":"A is Negative");
            Console.WriteLine(n2 % 2 == 0 ? "B is positive" : "B is Negative");
            
            Console.WriteLine((n1 % 2 == 0 && n2 % 2 == 0)? "Both is positive":"");
            Console.WriteLine((n1 % 2 != 0 && n2 % 2 !=0) ? "Both is negative" : "");
        }
    }
}
