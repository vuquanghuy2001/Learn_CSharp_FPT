using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_8
{
    interface Iset
    {
        void AcceptDetails(int valOne, string valTow);
    }
    interface IGet
    {
        void Display();
    }
    class Employee : Iset
    {
        int _empID;
        string _empName;
        public void AcceptDetails(int valOne,string valTow)
        {
            _empID = valOne;
            _empName = valTow;
        }
    }
}
