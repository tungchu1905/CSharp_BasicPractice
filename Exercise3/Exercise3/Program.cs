using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int total = 3;
            Person[] person = new Person[total];
            for (int i = 0; i < total; i++)
            {
                person[i] = new Person()
                {
                        name = Console.ReadLine()
                };
               
            }
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(person[i].ToString());
            }
        }
    }
}
