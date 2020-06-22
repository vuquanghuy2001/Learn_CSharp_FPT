using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practive_VuQuangHuy
{
    class Book : Product
    {
        public Book(int Id, string Name, int Price, string Producer) : base(Id, Name, Price, Producer)
        {

        }
        public override double computeTax()
        {
            return base.Price * 8 / 100;
            //int Tax = base.Price * 8 / 100;
            //Console.WriteLine("Book tax is: {0}",Tax);
            //return Tax;
        }
    }
}
