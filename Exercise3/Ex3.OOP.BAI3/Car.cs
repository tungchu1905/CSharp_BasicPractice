using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3.OOP.BAI3
{
    class Car : IVehiculo
    {
        int amount;
        public void Driver()
        {
            if (amount > 0)
            {
                Console.WriteLine("Driving");
            }else
            {
                Console.WriteLine("Fueling");
            }
        }

        public bool Refuel(int gas)
        {
            if(amount == 0)
            {
                amount += gas;
            }
            return true;
        }
    }
}
