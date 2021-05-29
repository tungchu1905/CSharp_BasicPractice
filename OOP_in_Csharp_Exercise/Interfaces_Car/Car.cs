using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces_Car
{
    public class Car : IVehiculo
    {
        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public int Fuel { get; set; }



        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not Fuel");
            }
           
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
                return true;
        }
    }
}
