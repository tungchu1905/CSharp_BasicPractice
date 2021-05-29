using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3.OOP.BAI2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            student.Study();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();
        }
    }
}
