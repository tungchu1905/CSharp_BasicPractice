using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_HE141487_TungCT
{
    class Program 
    {
        static int[] array = new int[1000];
        static int n = 0;
        static void Main(string[] args)
        {
            int option;
            do
            {
               
                Console.WriteLine("1. Add\n2.Show\n3.Search\n4.Statistic\n5.Exit");
                Console.Write("Enter an option(1 - 5): ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        if (n == 0)
                        {
                            Console.WriteLine("Not found");
                            break;
                        }
                        outputArray();
                        Console.WriteLine();
                        break;
                    case 3:
                        
                        int find = Convert.ToInt32(Console.ReadLine());
                        findnumber(find);
                        break;
                    case 4:
                       statistic();
                        break;
                    case 5:
                        break;
                }
            } while (option!=5);
        }
        static void add()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            array.SetValue(i, n);
            n++;
        }
         static void outputArray()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("Total data: " + n);
        }
         static void findnumber(int find)
        {
            bool check = false;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == find)
                {
                    Console.WriteLine("\n" + find + " is exist in array index: {0}", i);
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            if(check == false)
            {
                Console.WriteLine("Not exist");
            }
            
        }
        static void statistic()
        {
            int sum = 0, average = 0;
            int max = 0;
            int min = 1000;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
                average = sum / n;
                if(array[i] > max)
                {
                    max = array[i] ;
                }
                if( min > array[i])
                {
                     min = array[i];
                }
            }

            Console.WriteLine("sum: {0}", sum);
            Console.WriteLine("average: {0}", average);
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Min: {0}", min);
        }
        }
}
