using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._13_Alphabetic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAlpha = false;
            int count = 0;
            string s = Console.ReadLine();
            foreach (char c in s)
            {
                isAlpha = char.IsLetterOrDigit(c);
                if(isAlpha == true)
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
