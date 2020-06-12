using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_8
{
    abstract class CodeSnippet_2
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats food in order to survive");
        }
        public abstract void AnimalSound();
    }
    class Lion : CodeSnippet_2
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Lion roars");
        }
    }
}
