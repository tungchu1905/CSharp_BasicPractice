using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._15_Double_ReferenceNum
{
    class Program
    {
        static void Double(ref int number)
        {
            number += number;
        }
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Double(ref num);
            Console.WriteLine(num);
        }
    }
}
