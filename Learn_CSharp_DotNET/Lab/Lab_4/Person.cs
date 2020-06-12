using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Lab.Lab_4
{
    abstract class Person
    {
        protected string Name;
        protected int Phone;
        protected string Email;
        protected Person()
        {
            Name = "Huy";
            Phone = 0964576059;
            Email = "VQH@gmail.com";
        }
        protected Person(string Name,int Phone,string Email)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
        }

        public string PName
        {
            get { return Name; }
            set { Name = value; }
        }
        public int PPhone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        public string PEmail
        {
            get { return Email; }
            set { Email = value; }
        }

    }
}
