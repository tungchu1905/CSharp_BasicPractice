using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Exercise_Regex
{
    class Program
    {
       
        static void Main(string[] args)
        {
            CheckRegex check = new CheckRegex();
            Student student = new Student();

            student.InputInfor(check.checkRoll(student.Roll),
                check.checkName(student.Name),
                check.checkEmail(student.Email),
                check.checkPhone(student.Phone));

            Console.WriteLine(student.DisplayInfor());
        }
    }
}
