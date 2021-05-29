using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3.OOP.Bai4
{
   public abstract class Animal
    {
       public string Name;

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
}
