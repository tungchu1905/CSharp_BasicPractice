using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._6
{
    class ex6
    {
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = Convert.ToInt32(Console.ReadLine());
            int n5 = Convert.ToInt32(Console.ReadLine());
            int sum = n1 + n2 + n3 + n4 + n5;
            Console.WriteLine("Sum of 5 number = "+ sum);
            Console.WriteLine("Media = " + sum/5);
            minmax.findMax(n1, n2, n3, n4, n5);
            minmax.findMin(n1, n2, n3, n4, n5);
        }
    }
}
