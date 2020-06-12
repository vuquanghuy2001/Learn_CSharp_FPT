using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_9
{
    class Car
    {
        string _carType;
        public virtual string CarType
        {
            get
            {
                return _carType;
            }
            set
            {
                _carType = value;
            }
        }
    }
    class Ferrari : Car
    {
        string _carType;
        public override string CarType
        {
            get
            {
                return base.CarType;
            }
            set
            {
                base.CarType = value;
                _carType = value;
            }
        }
    }
}
