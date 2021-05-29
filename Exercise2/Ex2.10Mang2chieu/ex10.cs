using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._10Mang2chieu
{
    class ex10
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[10, 10];
            valid10.input(a, n, m);
            Console.WriteLine("Average group 1: " + valid10.Average(a, n, m, 1));
            Console.WriteLine("Average group 2: " + valid10.Average(a, n, m, 2));
        }
    }
}
