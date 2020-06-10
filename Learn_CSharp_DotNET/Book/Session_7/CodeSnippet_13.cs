using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_7
{
    class CodeSnippet_13
    {
        protected const double PI = 3.14;
        protected double Radius = 14.9;
        public virtual double Area()
        {
            return PI * Radius * Radius;
        }
    }
    class Cone : CodeSnippet_13
    {
        protected double Side = 10.2;
        public override double Area()
        {
            return PI * Radius * Side;
        }
    }
}
