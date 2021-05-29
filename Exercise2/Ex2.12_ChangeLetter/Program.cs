using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._12_ChangeLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ChangeLetter(text, position)) ;
            Console.ReadLine();
        }
        static string ChangeLetter(string text, int position)
        {
            
            return text.Substring(0,position) + text.Substring(position+1);
        }
    }
}
