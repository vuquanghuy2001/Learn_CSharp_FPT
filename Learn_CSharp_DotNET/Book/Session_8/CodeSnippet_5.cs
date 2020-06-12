using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_8
{
    interface CodeSnippet_5
    {
        void Habitat();
    }
    class Dog : CodeSnippet_5
    {
        public void Habitat()
        {
            Console.WriteLine("Can be housed with human beings");
        }
    }
}
