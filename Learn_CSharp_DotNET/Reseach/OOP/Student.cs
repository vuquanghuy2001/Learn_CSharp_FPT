using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Reseach.OOP
{
    class Student:Person
    {
        public Student(string Name,int Age,int Phone,string Add)
        {
            this.Name = Name;
            this.Age = Age;
            this.Phone = Phone;
            this.Add = Add;
        }

        public override void gotoschool()
        {
            Console.WriteLine("be di hoc");
        }
        public override void teaching()
        {
            throw new NotImplementedException();
        }

        public void display()
        {
            Console.WriteLine("Name:{0},Age={1},Phone={2},Add={3}.", Name, Age, Phone, Add);
        }
    }
}
