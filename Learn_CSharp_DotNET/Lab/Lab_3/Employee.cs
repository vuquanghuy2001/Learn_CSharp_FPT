using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Lab.Lab_3
{
    class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string address;
        protected long sin;
        protected double salary;

        public Employee(string firstname,string lastName,string address,long sin,double salary)
        {
            this.firstName = firstName ;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public Employee()
        {
        }

        public virtual void toString()
        {
            Console.WriteLine("firstName: "+firstName);
            Console.WriteLine("lastName: "+lastName);
            Console.WriteLine("address: "+address);
            Console.WriteLine("sin: "+sin);
            Console.WriteLine("salary: "+salary);
        }

        public double Bonus()
        {
            return salary * sin;
        } 
    }
}
