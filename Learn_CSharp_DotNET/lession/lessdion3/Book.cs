using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.lession.lessdion3
{
    class Book
    {
        String _bookName;
        public string Print()
        {
            return _bookName;
        }

        public void Input(string bkName)
        {
            _bookName = bkName;
        }
    }
}
