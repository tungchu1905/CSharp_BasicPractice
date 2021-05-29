using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4_Review_OOP
{
    class Student : People
    {
        public double DotnetMark;
        public double JavaMark;

        public Student(int id, string name, int age, double dotnetMark, double javaMark):
            base(id, name, age)
        {
            DotnetMark = dotnetMark;
            JavaMark = javaMark;
        }

        public double GetAverageMark()
        {
            return (DotnetMark + JavaMark) / 2;
        }

        public string ToString()
        {
            return base.ToString() + ", AverageMark: " + GetAverageMark();
        }
    }
}
