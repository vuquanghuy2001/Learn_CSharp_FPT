using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Lab.Lab_3
{
    class BooleanAccept
    {
        public int number;
        public string symbol;
        public string name;
        public double weight;

        public void Number()
        {
            System.Console.WriteLine("Enter atomic number: {0}"+number);
        }
        public void Symbol()
        {
            System.Console.WriteLine("Enter symbol: {0)" + symbol);
        }
        public void Name()
        {
            System.Console.WriteLine("Enter full name: {0}" + name);
        }
        public void Weight()
        {
            System.Console.WriteLine("Enter atomic weight: {0}" + weight);
        }

        public void Display()
        {
            System.Console.WriteLine("{0} {1} {2} {3}" + number, symbol, name, weight);
        }
    }
}
