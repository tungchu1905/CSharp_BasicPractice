using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces_Car
{
    public interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
}
