using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_9
{
    class Account
    {
        string[,] accountDetail = new string[4, 2];
        public string this[int pos, int column]
        {
            get
            {
                return (accountDetail[pos, column]);
            }
            set
            {
                accountDetail[pos, column] = value;
            }
        }
    }
}
