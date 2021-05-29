using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2
{
    class ex1
    {
        static void Main(string[] args)
        {
            int y;
            int xx = Convert.ToInt32(Console.ReadLine());
            int xxx = Convert.ToInt32(Console.ReadLine());

            for (int x = xx; x < xxx; x++)
            {
                y = x *x - 2 * x + 1;
                Console.Write(y + " ");
            }
        }
    }
}
