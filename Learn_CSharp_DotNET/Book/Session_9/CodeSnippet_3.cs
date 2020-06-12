using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_9
{
    class CodeSnippet_3
    {
        string _deptName;
        int _deptID;
        public string DeptName
        {
            set
            {
                _deptName = value;
            }
        }
        public int DeptID
        {
            set
            {
                _deptID = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Department Name: "+_deptName);
            Console.WriteLine("Department ID: "+_deptID);
        }
    }
}
