using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_9
{
    class Student
    {
        string[] studName = new string[2];
        public virtual string this[int index]
        {
            get
            {
                return studName[index];
            }
            set
            {
                studName[index] = value;
            }
        }
    }
    class Result : Student
    {
        string[] result = new string[2];
        public override string this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                base[index] = value;
            }
        }
    }
}
