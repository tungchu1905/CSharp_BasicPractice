using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3
{
    public class Person
    {
       public string name { get; set; }

        public Person()
        {
        }

        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is "+name;
        }
    }
}
