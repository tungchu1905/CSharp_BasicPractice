using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2._11_ObjectCar
{
    class Car
    {
        private string model;
        private int AnyoFabricacion;


        public string Model { get => model; set => model = value; }
        public int AnyoFabricacion1 { get => AnyoFabricacion; set => AnyoFabricacion = value; }
        public Car()
        {

        }
        public Car(string model, int anyoFabricacion)
        {
            this.model = model;
            AnyoFabricacion = anyoFabricacion;
        }

        public override string ToString()
        {
            return "Model: "+model+
                ", Year of production: "+AnyoFabricacion;
        }
       
    }
}
