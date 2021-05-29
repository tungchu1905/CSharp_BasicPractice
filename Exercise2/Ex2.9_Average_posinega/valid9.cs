using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._9
{
    class valid9
    {
        public static void input(int []a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a["+i+"]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void output(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
        public static int Average(int []a, int k)
        {
            int sum =0, count = 0;
            for (int i = 0; i < 10; i++)
            {
                if(a[i] > 0 && k==1)
                {
                    sum += a[i];
                    count++;
                }else if(a[i] < 0 && k==0)
                {
                    sum += a[i];
                    count++;
                }
            }
            return sum/count;
        }
        
    }
}
