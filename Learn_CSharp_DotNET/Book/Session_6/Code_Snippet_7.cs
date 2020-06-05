using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_6
{
    class Code_Snippet_7
    {
        public static void Addition(int val1, int val2)
        {
            Console.WriteLine(val1 + val2);
        }
        public void Multiply(int val1, int val2)
        {
            Console.WriteLine(val1 * val2);
        }
    }
    class StaticMethods
    {
        static void Main(string[] args)
        {
            Code_Snippet_7.Addition(10, 50);
            Code_Snippet_7 objCal = new Code_Snippet_7();
            objCal.Multiply(10, 20);
        }
    }
}
