using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._10Mang2chieu
{
    class valid10
    {
        public static void input(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[{0},{1}]- Group {2}: ", i, j, i+1);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public static void ouput(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(a[i,j] +" "  );
                    
                }
            }
        }
        public static float Average(int[,] a, int n, int m, int k)
        {
            float ave = 0;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(i == 0 && k==1)
                    {
                        ave += a[i, j];
                    }
                    if (i == 1 && k == 2)
                    {
                        ave += a[i, j];
                    }

                }
            }
            return ave/m;
        }
    }
}
