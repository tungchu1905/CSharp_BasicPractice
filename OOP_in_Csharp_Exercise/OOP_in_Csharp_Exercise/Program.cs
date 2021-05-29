using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_in_Csharp_Exercise
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();
        }
    }
}
