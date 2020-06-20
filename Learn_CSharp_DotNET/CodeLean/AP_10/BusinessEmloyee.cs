using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.CodeLean.AP_10
{
    class BusinessEmloyee : Employee
    {
        public double bonusBudget = 1000;
        public BusinessEmloyee(string name) : base(name, 50000)
        {

        }
        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
