using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3_ReviewOOP
{
    class Student : People
    {
        float DonetMark;
        float JavaMark;

        public float DonetMark1 { get => DonetMark; set => DonetMark = value; }
        public float JavaMark1 { get => JavaMark; set => JavaMark = value; }

        public Student(int id, string name, int age, float donetMark, float javaMark) : base(id, name, age)
        {
            DonetMark = donetMark;
            JavaMark = javaMark;
        }

        public Student()
        {
        }

        public float GetAverageMark()
        {
            float total = (this.DonetMark + this.JavaMark) / 2;
            return total;
        }
        public override string ToString()
        {
            return base.ToString() +"\tAverageMark: "+GetAverageMark();
        }
    }
}
