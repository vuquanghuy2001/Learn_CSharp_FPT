using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_6
{
    class Code_Snippet_4
    {
        void Count(int boys, int girls)
        {
            Console.WriteLine(boys + girls);
        }
        static void Main(string[] args)
        {
            Code_Snippet_4 objTest = new Code_Snippet_4();
            objTest.Count(boys: 16, girls: 24);
        }
    }
}
