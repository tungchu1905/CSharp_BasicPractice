using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._8
{
    class valid8
    {
        public static void inputArray(int[] a, int n)
        {
           
            for (int i = 0; i < n; i++)
            {
                Console.Write("a["+i+"]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void outputArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public static void findnumber(int[] a, int n, int find)
        {
            for (int i = 0; i < n; i++)
            {
               //Console.WriteLine(a[i] == find ? find + "is exist in array" : "end");
                if (a[i] == find)
                {
                    Console.WriteLine("\n"+find + "is exist in array");
                    break;
                }
            }
        }

    }
}
