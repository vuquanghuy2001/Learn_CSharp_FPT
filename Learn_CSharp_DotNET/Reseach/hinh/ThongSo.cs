using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Reseach.hinh
{
    class ThongSo
    {
        public int CD;
        public int CR;

        public int DT()
        {
            return CD * CR;
        }
        public int CV()
        {
            return 2 * (CD + CR);
        }
    }
}
