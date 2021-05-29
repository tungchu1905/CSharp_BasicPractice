using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_Regex
{
    class Student
    {
        public string roll;
        public string name;
        public string email;
        public int phone;

        public string Roll { get => roll; set => roll = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public int Phone { get => phone; set => phone = value; }

        public void InputInfor(string Roll, string Name, string Email, int Phone)
        {
            this.Roll = Roll;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
        }
       public string DisplayInfor()
        {
            return "Roll: " + Roll +
                "\nName: "+Name+
                "\nEmail: "+Email+
                "\nPhone" +Phone; 
        }
    }
}
