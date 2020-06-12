using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_8
{
    interface IAnimal
    {
        void Drink();
    }
    interface ICarnivorous
    {
        void Eat();
    }
    interface IReptile : IAnimal, ICarnivorous
    {
        void Habitat();
    }
    class Crocodile3 : IReptile
    {
        public void Drink()
        {
            Console.WriteLine("Drinks fresh water");
        }
        public void Habitat()
        {
            Console.WriteLine("Can stay in Water and Land");
        }
        public void Eat()
        {
            Console.WriteLine("Eats Flesh");
        }
    }
}
