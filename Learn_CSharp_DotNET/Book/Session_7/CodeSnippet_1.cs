using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_7
{
    class CodeSnippet_1
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
    }
    class Mammal : CodeSnippet_1
    {
        public void Feature()
        {
            Console.WriteLine("Mammals give birth to young ones.");
        }
    }
    class Dog : Mammal
    {
        public void Noise()
        {
            Console.WriteLine("Dog barks.");
        }
    }
    class Cat : CodeSnippet_1
    {
        public void NoiceCat()
        {
            Console.WriteLine("Meo Meo.");
        }
    }
}
