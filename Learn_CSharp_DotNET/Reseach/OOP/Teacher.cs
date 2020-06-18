using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Reseach.OOP
{
   public class Teacher:Person
    {
        public Teacher(string Name,int Age,int Phone,string Add)
        {
            this.Name = Name;
            this.Age = Age;
            this.Phone = Phone;
            this.Add = Add;
        }

        public override void gotoschool()
        {
            Console.WriteLine("duoc hoc");
        }

        public void display()
        {
            Console.WriteLine("Name:{0},Age={1},Phone={2},Add={3}.",Name,Age,Phone,Add);
        }

        public override void teaching()
        {
            Console.WriteLine();
        }
    }
}
