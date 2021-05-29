using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Ex2._6
{
    class minmax
    {
        public static int findMin(int t1, int t2, int t3, int t4, int t5)
        {
            int min;

            min = t1;
            if (t2 < min)
                min = t2;
            if (t3 < min)
                min = t3;
            if (t4 < min)
                min = t4;
            if (t5 < min)
                min = t5;
            Console.WriteLine("Min: " + min);
            return min;
        }

        public static int findMax(int n1, int n2, int n3, int n4, int n5)
        {
            int max = n1;
            if (n2 > max)
            {
                max = n2;
            }
            if (n3 > max)
            {
                max = n3;
            }
            if (n4 > max)
            {
                max = n4;
            }
            if (n5 > max)
            {
                max = n5;
            }
            Console.WriteLine("Max: " + max);
            return max;
        }
        public static SqlConnection connection()
        {
            return new SqlConnection();
        }
    }
    }
