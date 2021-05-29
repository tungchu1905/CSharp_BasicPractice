using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._4
{
    class ex4
    {
        static void Main(string[] args)
        {
            int f,s;
            do
            {
                f = Convert.ToInt32(Console.ReadLine());
                if (f == 0)
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                s = Convert.ToInt32(Console.ReadLine());
                if(s != 0)
                {
                    Console.WriteLine("The division is " + f / s);
                    Console.WriteLine("The rest is " + f % s);
                }
                else
                {
                    Console.WriteLine("You cannot divide by 0");
                }
            } while (f!=0);
        }
    }
}
