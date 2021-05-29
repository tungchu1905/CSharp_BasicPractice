using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3_ReviewOOP
{
    class Teacher : People
    { 
        int classNumber;
        int subjectNumber;

        public int ClassNumber { get => classNumber; set => classNumber = value; }
        public int SubjectNumber { get => subjectNumber; set => subjectNumber = value; }
        public Teacher(int id, string name, int age, int Classnumber, int Subjecnumber) : base(id, name, age)
        {
            classNumber = Classnumber ;
            subjectNumber = Subjecnumber;
        }

        public Teacher()
        {
        }

        public int TotalSubject()
        {
            int total = ClassNumber + SubjectNumber;
            return total;
        }
        public override string ToString()
        {

            return base.ToString() + "\tTotalSubject: " + TotalSubject();
        }
    }
}
