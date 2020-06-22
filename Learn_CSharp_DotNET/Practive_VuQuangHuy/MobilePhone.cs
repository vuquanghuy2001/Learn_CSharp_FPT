using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practive_VuQuangHuy
{
    class MobilePhone : Product
    {
        public MobilePhone(int Id, string Name, int Price, string Producer) :base( Id, Name, Price, Producer)
        {

        }
        public override double computeTax()
        {
            return base.Price * 10 / 100;

        }
    }
}
