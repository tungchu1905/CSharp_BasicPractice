using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._8
{
    class ex8
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[100];
            valid8.inputArray(a, n);
            Console.Write("Array LIST: ");
            valid8.outputArray(a, n);

            int find = Convert.ToInt32(Console.ReadLine());
            valid8.findnumber(a, n, find);
            Console.ReadLine();

        }
    }
}
