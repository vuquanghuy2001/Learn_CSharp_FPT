using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.CodeLean.AP_10
{
    class Run
    {
        public static void Test()
        {
            var employee1 = new Employee("Libby", 2000);
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmloyee("WInter");
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
