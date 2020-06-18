using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_11
{
    class TypeInitError
    {
        static TypeInitError()
        {
            throw new ApplicationException("This program throws typeInitializationException error.");
        }
    }
}
