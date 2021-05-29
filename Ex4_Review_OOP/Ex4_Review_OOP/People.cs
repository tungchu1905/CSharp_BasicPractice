using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4_Review_OOP
{
    class People
    {
        public int Id;
        public string Name;
        public int Age;

        public People(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string ToString()
        {
            return "ID: " + Id + ", Name: " + Name + ", Age: " + Age;
        }
    }
}
