using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3_ReviewOOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Check check = new Check();
            
            ArrayList list = new ArrayList();
            // CACH 1
            Console.WriteLine("Student 1: ");
            Student student1 = new Student();
            Console.Write("Input id: ");
            student1.id = check.checkInputInt(student1.id);
            Console.Write("Input name: ");
            student1.name = Console.ReadLine();
            Console.Write("Input age: ");
            student1.age = check.checkInputInt(student1.age);
            Console.Write("Input DonetMark: ");
            student1.DonetMark1 = check.checkInputFloat(student1.DonetMark1);
            Console.Write("Input JavaMark: ");
            student1.JavaMark1 = check.checkInputFloat(student1.JavaMark1);
            list.Add(student1);


            Console.WriteLine("Student 2: ");
            Student student2 = new Student();
            Console.Write("Input id: ");
            student2.id = check.checkInputInt(student2.id);
            Console.Write("Input name: ");
            student2.name = Console.ReadLine();
            Console.Write("Input age: ");
            student2.age = check.checkInputInt(student2.age);
            Console.Write("Input DonetMark: ");
            student2.DonetMark1 = check.checkInputFloat(student2.DonetMark1);
            Console.Write("Input JavaMark: ");
            student2.JavaMark1 = check.checkInputFloat(student2.JavaMark1);
            list.Add(student2);


          
            Console.WriteLine("Teacher 1: ");
            Teacher teacher1 = new Teacher();
            Console.Write("Input id: ");
            teacher1.id = check.checkInputInt(teacher1.id);
            Console.Write("Input name: ");
            teacher1.name = Console.ReadLine();
            Console.Write("Input age: ");
            teacher1.age = check.checkInputInt(teacher1.age);
            Console.Write("Input ClassNumber: ");
            teacher1.ClassNumber = check.checkInputInt(teacher1.ClassNumber);
            Console.Write("Input SubjectName: ");
            teacher1.SubjectNumber = check.checkInputInt(teacher1.SubjectNumber);
            list.Add(teacher1);

            Console.WriteLine("Teacher 2: ");
            Teacher teacher2 = new Teacher();
            Console.Write("Input id: ");
            teacher2.id = check.checkInputInt(teacher2.id);
            Console.Write("Input name: ");
            teacher2.name = Console.ReadLine();
            Console.Write("Input age: ");
            teacher2.age = check.checkInputInt(teacher2.age);
            Console.Write("Input ClassNumber: ");
            teacher2.ClassNumber = check.checkInputInt(teacher2.ClassNumber);
            Console.Write("Input SubjectName: ");
            teacher2.SubjectNumber = check.checkInputInt(teacher2.SubjectNumber);
            list.Add(teacher2);


            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Student)
                {
                    Student s = (Student)list[i];
                    Console.WriteLine(s.ToString());
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Teacher)
                {
                    Teacher s = (Teacher)list[i];
                    Console.WriteLine(s.ToString());
                }
            }



            ///CACH 2
            //    Student[] student = new Student[2];

            //    for (int i = 0; i < 2; i++)
            //    {
            //        Console.WriteLine("Student number: {0} ", i + 1);
            //        student[i] = new Student()
            //        {
            //            id = check.checkInputInt(student[i].id),
            //            name = Console.ReadLine(),
            //            age = Convert.ToInt32(Console.ReadLine()),
            //            DonetMark1 = float.Parse(Console.ReadLine()),
            //            JavaMark1 = float.Parse(Console.ReadLine())
            //        };
            //        list.Add(student[i]);
            //    }

            //    Teacher[] teacher = new Teacher[total];
            //    for (int i = 0; i < total; i++)
            //    {
            //        Console.WriteLine("\nTeacher number: {0} ", i + 1);
            //        teacher[i] = new Teacher()
            //        {
            //            id = Convert.ToInt32(Console.ReadLine()),
            //            name = Console.ReadLine(),
            //            age = Convert.ToInt32(Console.ReadLine()),
            //            ClassNumber = int.Parse(Console.ReadLine()),
            //            SubjectNumber = int.Parse(Console.ReadLine())
            //        };
            //        list.Add(teacher[i]);
            //    }
            //    foreach (Student item in list)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    foreach (Teacher item in list)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
        }
    }
}
