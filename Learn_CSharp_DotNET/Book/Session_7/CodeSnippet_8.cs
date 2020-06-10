using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_7
{
    class CodeSnippet_8
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
        
        protected void DoSomething()
        {
            Console.WriteLine("Every animal does something");
        }
    }
    class Cat3 : CodeSnippet_8
    {
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }
    }
}
