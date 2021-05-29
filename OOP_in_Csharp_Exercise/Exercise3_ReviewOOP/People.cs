using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3_ReviewOOP
{
    class People
    {
        public int id;
        public string name;
        public int age;

        public People()
        {
        }

        public People(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public virtual string ToString()
        {
            return "ID: " + id + "\tName: " + name + "\tAge: " + age;
        }
        
    }
}
