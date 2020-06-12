using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_9
{
    class Employee3
    {
        string _empName;
        int _empID;
        float _salary;
        public string EmpName
        {
            get
            {
                return _empName;
            }
            set
            {
                _empName = value;
            }
        }
        public int EmpID
        {
            get
            {
                return _empID;
            }
            set
            {
                _empID = value;
            }
        }
        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    _salary = 0;
                }
                else
                {
                    _salary = value;
                }
            }
        }
    }
    class SalaryDetail : Employee
    {

    }
}
