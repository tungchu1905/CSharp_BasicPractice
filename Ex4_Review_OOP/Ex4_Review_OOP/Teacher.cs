using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4_Review_OOP
{
    class Teacher : People
    {
        public int SubjectNumber;
        public int ClassNumber;

        public Teacher(int id, string name, int age, int subjectNumber, int classNumber):
            base(id, name, age)
        {
            SubjectNumber = subjectNumber;
            ClassNumber = classNumber;
        }

        public int GetTotalSubject()
        {
            return SubjectNumber * ClassNumber;
        }

        public string ToString()
        {
            return base.ToString() + ", Total subject: " + GetTotalSubject();
        }
    }
}
