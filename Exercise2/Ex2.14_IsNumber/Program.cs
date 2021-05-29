using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._14_IsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumber = false;
            int count = 0;
            string s = Console.ReadLine();
            foreach (char c in s)
            {
                isNumber = char.IsDigit(c);
                if (isNumber == true)
                {
                    count++;
                }
            }
            if (count == s.Length) 
            {
                Console.WriteLine("true");
            }
        }
    }
}
