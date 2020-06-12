using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_8
{
    interface ICalculate
    {
        double Area();
    }
    class Rectangle : ICalculate
    {
        float _length;
        float _Breadth;
        public Rectangle(float valOne,float ValTow)
        {
            _length = valOne;
            _Breadth = ValTow;
        }
        public double Area()
        {
            return _length * _Breadth;
        }
    }
}
