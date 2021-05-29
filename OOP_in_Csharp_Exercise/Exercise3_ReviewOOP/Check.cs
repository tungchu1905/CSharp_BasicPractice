using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3_ReviewOOP
{
    class Check
    {
        public int checkInputInt(int number)
        {
            while (true)
            {
                try
                {
             
                number = int.Parse(Console.ReadLine());
                if(number < 0)
                    {
                    Console.Write("Input posotive number: ");
                    continue;
                    }  
                    return number;
                }
            catch (Exception)
            {
                Console.Write("Input number: ");
                
            }
              
            }
            
        }
        public float checkInputFloat(float number)
        {
            while (true)
            {
            try
            {
                
                number = float.Parse(Console.ReadLine());
                if (number < 0)
                {
                        Console.Write("Input posotive number: ");
                        continue;
                }
                    return number;
            }
            catch (Exception)
            {
                Console.Write("Input number: ");
                throw;
            }
           
            }
        }

        public float checkMark(float number)
        {
            while (true)
            {
                try
                {

                    number = float.Parse(Console.ReadLine());
                    if (number < 0 || number >10)
                    {
                        Console.Write("Input posotive number: ");
                        continue;
                    }
                    return number;
                }
                catch (Exception)
                {
                    Console.Write("Input number: ");
                    throw;
                }

            }
        }
    }
}
