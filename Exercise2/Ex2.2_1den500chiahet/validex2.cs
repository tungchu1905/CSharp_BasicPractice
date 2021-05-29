using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._2
{
    class validex2
    {
        public static int check(int n)
        {
            int i;
            for ( i = 3; i < n; i+=3)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            return i;
        }
    }
}
