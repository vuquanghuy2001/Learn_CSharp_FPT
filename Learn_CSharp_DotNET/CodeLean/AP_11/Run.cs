using Learn_CSharp_DotNET.CodeLean.AP_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.CodeLean.AP_11
{
    class Run
    {
        public static void Test()
        {
            var employee1 = new TechnicalEmployee("Libby");
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new TechnicalEmployee("Winter");

            Console.WriteLine(employee1.employeeStatus()+" ... "+employee2.employeeStatus()+" ... "+employee3.employeeStatus());
        }
    }
}
