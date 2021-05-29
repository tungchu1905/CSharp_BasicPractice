using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ex4_Review_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao 1 ArrayList
            ArrayList list = new ArrayList();

            // Khai bao so luong SV va GV can quan ly
            int count = 2;
            Console.WriteLine("Nhap thong tin cho 2 sinh vien:");
            for(int i = 0; i< count; i++) 
            {
                Console.WriteLine("-- Sinh vien thu: #{0} --",i+1);
                Console.Write("Ma sinh vien: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ten sinh vien: ");
                string name = Console.ReadLine();
                Console.Write("Tuoi: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Diem .NET: ");
                double dotnet = Convert.ToDouble(Console.ReadLine());
                Console.Write("Diem Java: ");
                double java = Convert.ToDouble(Console.ReadLine());

                Student s = new Student(id, name, age, dotnet, java);
                // Them doi tuong s vao list
                list.Add(s);
            }

            Console.WriteLine("\nNhap thong tin cho 2 giang vien:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("-- Giang vien thu: #{0} --", i+1);
                Console.Write("Ma giang vien: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ten giang vien: ");
                string name = Console.ReadLine();
                Console.Write("Tuoi: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("So mon giang day: ");
                int subjectnumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("So lop giang day: ");
                int classnumber = Convert.ToInt32(Console.ReadLine());

                Teacher t = new Teacher(id, name, age, subjectnumber, classnumber);
                // Them doi tuong s vao list
                list.Add(t);
            }

            // Hien thi thong tin sinh vien
            Console.WriteLine("\n---Danh sach sinh vien gom:---");
            for(int i = 0; i< list.Count; i++)
            {
                if(list[i] is Student)
                {
                    Student s = (Student)list[i];
                    Console.WriteLine(s.ToString());
                }
            }

            // Hien thi thong tin giang vien
            Console.WriteLine("\n---Danh sach giang vien gom:---");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Teacher)
                {
                    Teacher t = (Teacher)list[i];
                    Console.WriteLine(t.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
