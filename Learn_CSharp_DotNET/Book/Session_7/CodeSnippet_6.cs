using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_7
{
    class CodeSnippet_6
    {
       public CodeSnippet_6()
        {
            Console.WriteLine("Animal constructor without parameters");
        }
        public CodeSnippet_6(String name)
        {
            Console.WriteLine("Animal constructor with a string parameter");
        }
    }
    class Canine:CodeSnippet_6
    {
        public Canine() : base("lion")
        {
            Console.WriteLine("Derived Canine");
        }
    }
}
