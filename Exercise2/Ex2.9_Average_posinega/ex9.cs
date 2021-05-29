using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._9
{
    class ex9
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] a = new int[100];
            valid9.input(a, n);
            Console.WriteLine("Avarage number positive: " + valid9.Average(a,1));
            Console.WriteLine("Avarage number negative: " + valid9.Average(a,0));
        }
    }
}
