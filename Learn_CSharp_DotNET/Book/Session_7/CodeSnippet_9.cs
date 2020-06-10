using Learn_CSharp_DotNET.lession.lessdion3.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_7
{
    class CodeSnippet_9
    {
        string _studentName = "Jame";
        string _address = "Califoria";
        public virtual void PrintDeails()
        {
            Console.WriteLine("Student Name: "+_studentName);
            Console.WriteLine("Address: "+_address);
        }
    }
    class Grade : CodeSnippet_9
    {
        string _class = "Four";
        float _percent = 71.25f;
        public override void PrintDeails()
        {
            Console.WriteLine("Class: "+_class);
            Console.WriteLine("Percentage: "+_percent);
        }
    }
}
