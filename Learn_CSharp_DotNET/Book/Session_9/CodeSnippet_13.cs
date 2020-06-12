using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_9
{
    class Numbers
    {
        private int[] num = new int[3];
        public int this [int index]
        {
            get
            {
                return num[index];
            }
            set
            {
                num[index] = value;
            }
        }
    }
    class EvemNumbers : Numbers
    {

    }
}
