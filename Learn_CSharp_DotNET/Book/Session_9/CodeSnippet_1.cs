using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_9
{
    class CodeSnippet_1
    {
        private string _empName;
        public string EmployeeName
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
    }
}
