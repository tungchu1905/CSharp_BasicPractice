using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3.OOP.BAI3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            int gasoline = Convert.ToInt32(Console.ReadLine());
            car.Refuel(gasoline);
            car.Driver();
        }
    }
}
