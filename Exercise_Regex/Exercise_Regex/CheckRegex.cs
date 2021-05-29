using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Exercise_Regex
{
    class CheckRegex
    {
       public int checkPhone(int phone)
        {
            string patten = @"^\d{10}$";
            Regex regex = new Regex(patten);
            Console.WriteLine("Phone: ");
            //Regex myregex = new Regex(patten);
            while (true)
            {
                try
                {
                    phone = int.Parse(Console.ReadLine());
                    if (regex.IsMatch(phone.ToString()))
                    {
                       return phone;
                    }
                    else
                    {
                        
                        Console.WriteLine("phone is not right format");
                        continue;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Phone not contain text");

                }
            }

        }
        public string checkEmail(string email)
        {
            string patten = @"^(\w[\.\-]+)@([\w]+)((\.(\w){2,3})\.[a-z]+{2})$";
            Regex regex = new Regex(patten);
            Console.WriteLine("Email: ");
            //Regex myregex = new Regex(patten);
            while (true)
            {
                    email = Console.ReadLine();
                    if (!regex.IsMatch(email))
                    {
                        Console.WriteLine("mail is not right format");
                        continue;
                    }
                    else
                    {
                        return email;
                    }
            }

        }
        public string checkRoll(string roll)
        {
            string patten = @"^(HE|SE)\d{6}$";
            Regex regex = new Regex(patten);
            Console.WriteLine("Roll: ");
            while (true)
            {   
                roll = Console.ReadLine();
                if (!regex.IsMatch(roll))
                {
                    Console.WriteLine("roll is not right format");
                    continue;
                }
                else
                {
                    return roll;
                }
            }

        }

        public string checkName(string name)
        {
            string patten = @"^[a-zA-Z\s]+$";
            Regex regex = new Regex(patten);
            Console.WriteLine("Name: ");
            while (true)
            {
                name = Console.ReadLine();
                if (!regex.IsMatch(name))
                {
                    Console.WriteLine("Name is not right format");
                    continue;
                }
                else
                {
                    return name;
                }
            }

        }
    }
}
