using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Reseach.OOP
{
  public  abstract class Person
    {
        public string Name;
        public int Age;
        public int Phone;
        public string Add;
        public void Eat()
        {
            Console.WriteLine("toi an com");
        }
        public abstract void gotoschool();
        public abstract void teaching();
    }
}
