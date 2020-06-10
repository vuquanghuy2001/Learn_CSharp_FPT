using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_7
{
    class CodeSnippet_7
    {
        string _metalType;
        public CodeSnippet_7(string type)
        {
            _metalType = type;
            Console.WriteLine("Metal: \t\t" + _metalType);
        }
    }
    class SteelCompany : CodeSnippet_7
    {
        string _grade;
        public SteelCompany(string grade) : base("Steel")
        {
            _grade = grade;
            Console.WriteLine("Grade: \t\t" + _grade);
        }
    }
    class Automobiles : SteelCompany
    {
        string _part;
        public Automobiles(string part) : base("Cast Iron")
        {
            _part = part;
            Console.WriteLine("Part: \t\t" + _part);
        }
    }
}
