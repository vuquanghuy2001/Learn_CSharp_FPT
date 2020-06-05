using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_6
{
    class Code_Snippet_3
    {
        void printName(String firstName, String lastName)
        {
            Console.WriteLine("First Name = {0}, Last Name = {1}", firstName, lastName);
        }
        static void Main(string[] args)
        {
            Code_Snippet_3 student = new Code_Snippet_3();
            student.printName("Henry","Parker");
            student.printName(firstName: "Henry", lastName: "Parker");
            student.printName(lastName: "Parker", firstName: "Henry");
            student.printName("Henry", lastName: "Parker");
        }
    }
}
