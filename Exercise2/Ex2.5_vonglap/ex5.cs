using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._5
{
    class ex5
    {
        static void Main(string[] args)
        {
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i <= y; i++)
            {
                Console.Write(i+" ");
            }
            int ii = x;
            Console.WriteLine();
            while (ii<=y)
            {
                Console.Write(ii + " ");
                ii++;
            }
            Console.WriteLine();
            int iii = x;
            do
            {
                Console.Write(iii + " ");
                ++iii;
            } while (iii<=y);
        }
    }
}
