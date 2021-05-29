using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._3
{
    class ex3
    {
        static void Main(string[] args)
        {
            int user, pass;
            int count = 0;
            do
            {
                user = Convert.ToInt32( Console.ReadLine());
                pass = Convert.ToInt32(Console.ReadLine());
                count++;
                
                if (user!=12 || pass != 1234)
                {
                    Console.WriteLine("Login Fail");
                    if (count == 3)
                    {
                    Console.WriteLine("You fail too much.");
                    break;
                    }
                }
                else
                {
                    Console.WriteLine("Login Success");
                    break;
                }
            } while ((user !=12 || pass != 1234));
        }
    }
}

